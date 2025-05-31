using HashWarden.Data;
using HashWarden.Forms.Dialogs;
using HashWarden.Helpers;

namespace HashWarden
{
    public partial class SavedPasswordForm : Form
    {
        private Password _savedPassword;

        public SavedPasswordForm(Password password)
        {
            InitializeComponent();
            this._savedPassword = password;

            if (_savedPassword.Title != null)
                this.TitleLabel.Text = _savedPassword.Title;
            else
                this.TitleLabel.Text = Utils.CreateTitleFromUrl(_savedPassword.ServiceUrl);

            this.UsernameLabel.Text = _savedPassword.UserName;
            this.PasswordLabel.Text = "************";
            this.ServiceNameLabel.Text = _savedPassword.ServiceUrl;
            if (_savedPassword.Folder != null && _savedPassword.Folder.FolderName != null)
                this.FolderLabel.Text = _savedPassword.Folder.FolderName;
            else
                this.FolderLabel.Text = "Brak folderu";

            UpdatedAtLabel.Text += _savedPassword.UpdatedAt;
            CreatedAtLabel.Text += _savedPassword.CreatedAt;
        }

        private void ViewPassButton_Click(object sender, EventArgs e)
        {
            if (this.ViewPassButton.ImageIndex == 0)
            {
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
                var decrypted = EncryptionProvider.Decrypt(_savedPassword.EncryptedPassword, key, _savedPassword.Iv);

                this.PasswordLabel.Text = decrypted;
                this.ViewPassButton.ImageIndex = 1;
            }
            else
            {
                this.PasswordLabel.Text = "************";
                this.ViewPassButton.ImageIndex = 0;
            }
        }

        private async void EditRecordButton_Click(object sender, EventArgs e)
        {
            var addPasswordDialog = new AddPasswordForm(Utils.LoggedUser.Id, true, _savedPassword);
            if (addPasswordDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Hasło zaktualizowane");
                await Utils.ReloadData();
            }
        }

        private async void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz usunąć ten wpis?\nNie będzie można go przywrócić.",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            try
            {
                if (result == DialogResult.Yes && _savedPassword != null)
                {
                    using (var context = new HashWardenDbContext())
                    {
                        context.Passwords.Remove(_savedPassword);
                        context.SaveChangesAsync();
                    }

                    MessageBox.Show("Usunięto wpis.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await Utils.ReloadData();
                }
            }
            catch(Npgsql.NpgsqlException ex)
            {
                MessageBox.Show("Usunięto wpis.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Utils.ReloadData();
            }
        }
    }
}
