using HashWarden.Data;
using HashWarden.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace HashWarden.Forms.Dialogs
{
    public partial class AddPasswordForm : Form
    {
        private int _userId;
        private bool _isEditing;
        private Password? _editedPassword;

        public AddPasswordForm(int userId, bool isEditing, Password? editedPassword = null)
        {
            InitializeComponent();
            _userId = userId;
            _isEditing = isEditing;
            _editedPassword = editedPassword;

            StartPosition = FormStartPosition.CenterScreen;
            FolderPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            _ = InitializeFormAsync();
        }

        private async Task InitializeFormAsync()
        {
            await LoadFolderPicker();

            if (_isEditing)
            {
                EditedDataLoader();
                AddButton.Text = "Zapisz";
                this.Text = "Edycja wpisu";
            }
        }

        // Wczytanie listy folderów
        private async Task LoadFolderPicker()
        {
            using (var context = new HashWardenDbContext())
            {
                var folders = await context.Folders
                    .Where(f => f.UserId == _userId)
                    .ToListAsync();

                folders.Insert(0, new Folder { Id = 0, FolderName = "Brak" });

                FolderPicker.DataSource = folders;
                FolderPicker.DisplayMember = "FolderName";
                FolderPicker.ValueMember = "Id";
                FolderPicker.SelectedValue = 0;
            }
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            var title = TitleInput.Text.Trim();
            var username = UsernameInput.Text.Trim();
            var password = PasswordInput.Text.Trim();
            var serviceUrl = ServiceUrlInput.Text.Trim().ToLower();
            
            Folder? folder = null;
            if(FolderPicker.SelectedItem != null && !FolderPicker.SelectedItem.Equals("Brak"))
                folder = FolderPicker.SelectedItem as Folder;

            var date = DateOnly.FromDateTime(DateTime.UtcNow);

            // Walidacja tytułu (nieobowiązkowy)
            if (title.Length > 40)
            {
                MessageBox.Show("Tytuł musi mieć mniej niż 40 znaków.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Walidacja nazwy użytkownika
            if (string.IsNullOrWhiteSpace(username) || username.Length > 40)
            {
                MessageBox.Show("Nazwa użytkownika nie może być pusta i musi mieć mniej niż 40 znaków.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Walidacja hasła
            if (!Utils.PasswordValidation(password))
                return;

            // Walidacja adresu strony
            var serviceUrlRegex = new Regex(@"^www\.[a-z0-9-]+\.[a-z]{2,24}$");
            if (!serviceUrlRegex.IsMatch(serviceUrl))
            {
                MessageBox.Show("Nieprawidłowy format adresu strony.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] salt = Utils.LoggedUser.Salt;
            byte[]? key = SessionKeyManager.GetKey();
            byte[] iv;
            byte[] encrypted;

            if (key == null)
            {
                var masterPasswordDialog = new MasterPasswordForm();
                if (masterPasswordDialog.ShowDialog() == DialogResult.OK)
                {
                    var masterPassword = masterPasswordDialog.GetPassword();
                    key = EncryptionProvider.GenerateKeyFromPassword(masterPassword, salt);
                }
            }

            using (var aes = System.Security.Cryptography.Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();
                iv = aes.IV;
                encrypted = EncryptionProvider.Encrypt(password, key, iv);
            }

            Password savedPassword = new Password
            {
                UserId = _userId,
                Title = title,
                UserName = username,
                ServiceUrl = serviceUrl,
                EncryptedPassword = encrypted,
                Iv = iv,
                CreatedAt = date,
                UpdatedAt = date,
                FolderId = folder != null && folder.Id != 0 ? folder.Id : null
            };

            using (var context = new HashWardenDbContext())
            {
                if (_isEditing && _editedPassword != null)
                {
                    var editedPasswordDb = await context.Passwords
                        .FirstOrDefaultAsync(p => p.Id == _editedPassword.Id);

                    if (editedPasswordDb == null)
                    {
                        MessageBox.Show("Nie znaleziono wpisu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    editedPasswordDb.Title = savedPassword.Title;
                    editedPasswordDb.UserName = savedPassword.UserName;
                    editedPasswordDb.ServiceUrl = savedPassword.ServiceUrl;
                    editedPasswordDb.EncryptedPassword = savedPassword.EncryptedPassword;
                    editedPasswordDb.Iv = savedPassword.Iv;
                    editedPasswordDb.UpdatedAt = savedPassword.UpdatedAt;
                    editedPasswordDb.FolderId = savedPassword.FolderId;
                }
                else
                    await context.Passwords.AddAsync(savedPassword);
                
                await context.SaveChangesAsync();
            }
            if(!_isEditing)
                MessageBox.Show("Dodano rekord", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.DialogResult = DialogResult.OK;
        }

        private void EditedDataLoader()
        {
            if (_editedPassword == null)
                return;

            byte[] key = SessionKeyManager.GetKey();
            if (key == null)
            {
                var masterPasswordDialog = new MasterPasswordForm();
                if (masterPasswordDialog.ShowDialog() == DialogResult.OK)
                {
                    var masterPassword = masterPasswordDialog.GetPassword();
                    key = EncryptionProvider.GenerateKeyFromPassword(masterPassword, Utils.LoggedUser.Salt);
                }
            }
            var decrypted = EncryptionProvider.Decrypt(_editedPassword.EncryptedPassword, key, _editedPassword.Iv);
            this.PasswordInput.Text = decrypted;

            TitleInput.Text = _editedPassword.Title;
            UsernameInput.Text = _editedPassword.UserName;
            ServiceUrlInput.Text = _editedPassword.ServiceUrl;
            FolderPicker.SelectedValue = _editedPassword.FolderId ?? 0;
        }

        private void ViewPassButton_Click(object sender, EventArgs e)
        {
            if (this.ViewPassButton.ImageIndex == 0)
            {
                this.PasswordInput.UseSystemPasswordChar = false;
                this.ViewPassButton.ImageIndex = 1;
            }
            else
            {
                this.PasswordInput.UseSystemPasswordChar = true;
                this.ViewPassButton.ImageIndex = 0;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
