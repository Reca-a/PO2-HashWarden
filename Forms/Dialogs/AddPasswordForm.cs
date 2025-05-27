using HashWarden.Data;
using HashWarden.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.RegularExpressions;

namespace HashWarden.Forms.Dialogs
{
    public partial class AddPasswordForm : Form
    {
        private int _userId;

        public AddPasswordForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            StartPosition = FormStartPosition.CenterScreen;
            FolderPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadFolderPicker();
        }

        // Wczytanie listy folderów
        private async void LoadFolderPicker()
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

                if (folders.Count > 0)
                    FolderPicker.SelectedIndex = 0;
            }
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            var title = TitleInput.Text.Trim();
            var username = UsernameInput.Text.Trim();
            var password = PasswordInput.Text.Trim();
            var serviceUrl = ServiceUrlInput.Text.Trim().ToLower();
            
            Folder folder = null;
            if(!FolderPicker.SelectedItem.Equals("Brak"))
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
            byte[] key = SessionKeyManager.GetKey();
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
                FolderId = folder.Id
            };

            using (var context = new HashWardenDbContext())
            {
                await context.Passwords.AddAsync(savedPassword);
                await context.SaveChangesAsync();
            }

            MessageBox.Show("Dodano rekord", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
