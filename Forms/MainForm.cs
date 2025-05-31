using HashWarden.Data;
using HashWarden.Forms.Components;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using HashWarden.Forms.Dialogs;
using HashWarden.Helpers;

namespace HashWarden
{
    public partial class MainForm : Form
    {
        private Size _formSize;
        private Form? _activeSubForm { get; set; }

        private Folder? _loadedFolder;

        public MainForm()
        {
            InitializeComponent();
            LoadFolders();
            Utils.LoggedUserRefreshed += OnLoggedUserRefreshed;
        }

        private void OnLoggedUserRefreshed(bool isChanged)
        {
            Invoke(() =>
            {
                LoadFolders();
                if (_loadedFolder != null)
                    FolderButtonClicked(this.FolderListPanel, _loadedFolder);
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

                foreach (Folder folder in Utils.LoggedUser.Folders)
                {
                    var folderButton = new FolderButtonComponent(folder);
                    folderButton.FolderClicked += FolderButtonClicked;
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
        private async void FolderButtonClicked(object sender, Folder folder)
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

                foreach (var password in loadedFolder.Passwords)
                {
                    var siteButton = new SiteButtonComponent(password);
                    siteButton.SiteClicked += SiteButtonClicked;
                    PasswordListPanel.Controls.Add(siteButton);
                }

                _loadedFolder = loadedFolder;
            }
        }

        // Wyświetlenie zapisanego rekordu
        private async void SiteButtonClicked(object sender, Password password)
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

            if (!Utils.LoggedUser.Passwords.Any())
            {
                PasswordListPanel.Controls.Add(new Label
                {
                    Text = "Brak haseł na koncie",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Height = 100,
                    AutoSize = true
                });
                return;
            }

            foreach (var password in Utils.LoggedUser.Passwords)
            {
                var siteButton = new SiteButtonComponent(password);
                siteButton.SiteClicked += SiteButtonClicked;
                PasswordListPanel.Controls.Add(siteButton);
            }
            _loadedFolder = null;
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

                MessageBox.Show("Folder dodany");
                await Utils.ReloadData();
            }
        }

        // Dodanie nowego zapisanego hasła
        private async void AddRecordButton_Click(object sender, EventArgs e)
        {
            var addPasswordDialog = new AddPasswordForm(Utils.LoggedUser.Id, false);
            if (addPasswordDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Hasło dodane");
                await Utils.ReloadData();
            }
        }
    }
}
