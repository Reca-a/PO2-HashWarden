using HashWarden.Data;
using HashWarden.Forms.Components;
using Microsoft.EntityFrameworkCore;
using HashWarden.Forms.Dialogs;
using HashWarden.Helpers;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HashWarden
{
    public partial class MainForm : Form
    {
        private Form? _activeSubForm { get; set; }

        private Folder? _loadedFolder;

        private string _folderSearchText = "";
        private string _passwordSearchText = "";
        private SortOrder _folderSortOrder = SortOrder.Ascending;
        private SortOrder _passwordSortOrder = SortOrder.Ascending;

        public MainForm()
        {
            InitializeComponent();
            LoadFolders();
            Utils.LoggedUserRefreshed += OnLoggedUserRefreshed;

            PasswordListPanel.WrapContents = true;
            FolderListPanel.WrapContents = false;
        }

        private void OnLoggedUserRefreshed(bool isChanged)
        {
            Invoke(() =>
            {
                LoadFolders();
                if (_loadedFolder != null)
                    FolderButton_Click(this.FolderListPanel, _loadedFolder);
                else
                    AllElementsButton_Click(this.FolderListPanel, new EventArgs());
            });
        }

        // Załadowanie folderów użytkownika
        private void LoadFolders()
        {
            try
            {
                FolderListPanel.Controls.Clear();

                if (!Utils.LoggedUser.Folders.Any())
                {
                    Label noFolderLabel = new Label();
                    noFolderLabel.Text = "Brak folderów";
                    noFolderLabel.TextAlign = ContentAlignment.MiddleCenter;
                    noFolderLabel.Dock = DockStyle.Fill;
                    FolderListPanel.Controls.Add(noFolderLabel);
                    return;
                }

                // Filtrowanie i sortowanie folderów
                var folders = Utils.LoggedUser.Folders.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(_folderSearchText))
                {
                    folders = folders.Where(f => f.FolderName.Contains(_folderSearchText, StringComparison.OrdinalIgnoreCase));
                }

                folders = _folderSortOrder == SortOrder.Ascending
                    ? folders.OrderBy(f => f.FolderName)
                    : folders.OrderByDescending(f => f.FolderName);

                var folderList = folders.ToList();

                if (!folderList.Any())
                {
                    Label noResultLabel = new Label();
                    noResultLabel.Text = "Brak wyników wyszukiwania";
                    noResultLabel.TextAlign = ContentAlignment.MiddleCenter;
                    noResultLabel.Dock = DockStyle.Fill;
                    FolderListPanel.Controls.Add(noResultLabel);
                    return;
                }

                foreach (Folder folder in folderList)
                {
                    var folderButton = new FolderButtonComponent(folder);
                    folderButton.FolderClicked += FolderButton_Click;
                    FolderListPanel.Controls.Add(folderButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wczytać folderów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        // Obsługa naciśnięcia na przycisk folderu
        private async void FolderButton_Click(object sender, Folder folder)
        {
            PasswordListPanel.Controls.Clear();

            using (var context = new HashWardenDbContext())
            {
                var loadedFolder = await context.Folders
                    .Include(f => f.Passwords)
                    .FirstOrDefaultAsync(f => f.Id == folder.Id);

                if (loadedFolder == null || !loadedFolder.Passwords.Any())
                {
                    PasswordListPanel.Controls.Add(new Label
                    {
                        Text = "Brak haseł w tym folderze",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Height = 100,
                        AutoSize = true
                    });
                    return;
                }

                LoadPasswordsForFolder(loadedFolder.Passwords.ToList());
                _loadedFolder = loadedFolder;
            }
        }

        // Ladowanie haseł
        private void LoadPasswordsForFolder(List<Password> passwords)
        {
            PasswordListPanel.Controls.Clear();

            if (!passwords.Any())
            {
                PasswordListPanel.Controls.Add(new Label
                {
                    Text = "Brak haseł",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Height = 100,
                    AutoSize = true
                });
                return;
            }

            // Filtrowanie i sortowanie haseł
            var filteredPasswords = passwords.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(_passwordSearchText))
            {
                filteredPasswords = filteredPasswords.Where(p =>
                    p.Title.Contains(_passwordSearchText, StringComparison.OrdinalIgnoreCase) ||
                    (!string.IsNullOrEmpty(p.UserName) && p.UserName.Contains(_passwordSearchText, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrEmpty(p.ServiceUrl) && p.ServiceUrl.Contains(_passwordSearchText, StringComparison.OrdinalIgnoreCase)));
            }

            filteredPasswords = _passwordSortOrder == SortOrder.Ascending
                ? filteredPasswords.OrderBy(p => p.Title)
                : filteredPasswords.OrderByDescending(p => p.Title);

            var passwordList = filteredPasswords.ToList();

            if (!passwordList.Any())
            {
                PasswordListPanel.Controls.Add(new Label
                {
                    Text = "Brak wyników wyszukiwania",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Height = 100,
                    AutoSize = true
                });
                return;
            }

            foreach (var password in passwordList)
            {
                var siteButton = new SiteButtonComponent(password);
                siteButton.SiteClicked += SiteButton_Click;
                PasswordListPanel.Controls.Add(siteButton);
            }
        }

        // Wyświetlenie zapisanego rekordu
        private async void SiteButton_Click(object sender, Password password)
        {
            if (password == null)
            {
                ContentPanel.Controls.Clear();

                ContentPanel.Controls.Add(new Label
                {
                    Text = "Brak danych",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top
                });
                return;
            }

            using (var context = new HashWardenDbContext())
            {
                var loadedPassword = await context.Passwords
                    .Include(p => p.User)
                    .Include(p => p.Folder)
                    .FirstOrDefaultAsync(p => p.Id == password.Id);

                if (loadedPassword == null)
                {
                    MessageBox.Show("Nie znaleziono hasła", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var passwordSubForm = new SavedPasswordForm(loadedPassword);
                OpenSubForm(passwordSubForm);
            }
        }

        // Wyświetlenie wszystkich haseł na koncie
        private void AllElementsButton_Click(object sender, EventArgs e)
        {
            PasswordListPanel.Controls.Clear();
            _loadedFolder = null;
            LoadPasswordsForFolder(Utils.LoggedUser.Passwords.ToList());
        }

        //Otwieranie podformularzy w aplikacji
        private void OpenSubForm(Form subForm)
        {
            if (_activeSubForm != null)
                _activeSubForm.Close();

            _activeSubForm = subForm;
            _activeSubForm.TopLevel = false;
            _activeSubForm.FormBorderStyle = FormBorderStyle.None;
            _activeSubForm.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(_activeSubForm);
            ContentPanel.Tag = _activeSubForm;
            _activeSubForm.BringToFront();
            _activeSubForm.Show();
        }

        // Wylogowanie
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz się wylogować?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        // Ustawienia
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        // Dodanie nowego folderu
        private async void AddFolderButton_Click(object sender, EventArgs e)
        {
            var addFolderDialog = new AddFolderForm(Utils.LoggedUser.Id);
            if (addFolderDialog.ShowDialog() == DialogResult.OK)
            {
                var folderName = addFolderDialog.FolderName;
                var newFolder = new Folder
                {
                    FolderName = folderName,
                    UserId = Utils.LoggedUser.Id
                };

                using (var context = new HashWardenDbContext())
                {
                    context.Folders.Add(newFolder);
                    await context.SaveChangesAsync();
                }

                MessageBox.Show("Folder dodany", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Utils.ReloadData();
            }
        }

        // Dodanie nowego zapisanego hasła
        private async void AddRecordButton_Click(object sender, EventArgs e)
        {
            var addPasswordDialog = new AddPasswordForm(Utils.LoggedUser.Id, false);
            if (addPasswordDialog.ShowDialog() == DialogResult.OK)
            {
                await Utils.ReloadData();
            }
        }

        // Obsługa wyszukiwania folderów
        private void FolderSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SearchFolders(FolderSearchTextBox.Text);
            }
        }

        private void FolderSearchButton_Click(object sender, EventArgs e)
        {
            SearchFolders(FolderSearchTextBox.Text);
        }

        private void FolderClearSearchButton_Click(object sender, EventArgs e)
        {
            FolderSearchTextBox.Clear();
            ClearFolderSearch();
        }

        private void FolderSortButton_Click(object sender, EventArgs e)
        {
            ToggleFolderSort();
        }

        private void PasswordSearchButton_Click(object sender, EventArgs e)
        {
            SearchPasswords(PasswordSearchTextBox.Text);
        }

        private void PasswordClearSearchButton_Click(object sender, EventArgs e)
        {
            PasswordSearchTextBox.Clear();
            _passwordSearchText = "";
            if (_loadedFolder != null)
            {
                LoadPasswordsForFolder(_loadedFolder.Passwords.ToList());
            }
            else
            {
                LoadPasswordsForFolder(Utils.LoggedUser.Passwords.ToList());
            }
        }

        private void PasswordSortButton_Click(object sender, EventArgs e)
        {
            TogglePasswordSort();
        }

        private void PasswordSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SearchPasswords(PasswordSearchTextBox.Text);
            }
        }

        // Metody do wyszukiwania folderów
        public void SearchFolders(string searchText)
        {
            searchText = searchText.Trim();

            var folderSearchRegex = new Regex(@"^[a-zA-Z0-9 ]{1,49}$");
            if (!folderSearchRegex.IsMatch(searchText))
            {
                MessageBox.Show("Wpisz poprawną nazwę folderu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _folderSearchText = searchText;
            SearchFolders(_folderSearchText);

            LoadFolders();
        }

        public void ClearFolderSearch()
        {
            _folderSearchText = "";
            LoadFolders();
        }

        public void ToggleFolderSort()
        {
            _folderSortOrder = _folderSortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            LoadFolders();
        }

        // Metody do wyszukiwania haseł
        public void SearchPasswords(string searchText)
        {
            searchText = searchText.Trim();

            if (string.IsNullOrWhiteSpace(searchText) || searchText.Length > 40)
            {
                MessageBox.Show("Wpisz tytuł wpisu, nazwę użytkownika lub nazwę strony", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _passwordSearchText = searchText;

            if (_loadedFolder != null)
            {
                LoadPasswordsForFolder(_loadedFolder.Passwords.ToList());
            }
            else
            {
                LoadPasswordsForFolder(Utils.LoggedUser.Passwords.ToList());
            }
        }

        public void TogglePasswordSort()
        {
            _passwordSortOrder = _passwordSortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            if (_loadedFolder != null)
            {
                LoadPasswordsForFolder(_loadedFolder.Passwords.ToList());
            }
            else
            {
                LoadPasswordsForFolder(Utils.LoggedUser.Passwords.ToList());
            }
        }

        // Enum dla kierunku sortowania
        public enum SortOrder
        {
            Ascending,
            Descending
        }
    }
}