﻿using HashWarden.Data;
using HashWarden.Forms.Dialogs;
using HashWarden.Helpers;
using Microsoft.EntityFrameworkCore;

namespace HashWarden
{
    public partial class SavedPasswordForm : Form
    {
        private Password? _savedPassword;

        public SavedPasswordForm(Password password)
        {
            InitializeComponent();
            this._savedPassword = password;
            LoadRecord();
        }

        private void LoadRecord()
        {
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
                this.FolderLabel.Text = "Brak";

            UpdatedAtLabel.Text = $"Aktualizowano: {_savedPassword.UpdatedAt.ToString()}";
            CreatedAtLabel.Text = $"Utworzono: {_savedPassword.CreatedAt.ToString()}";
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
                await Utils.ReloadData();
                try
                {
                    using (var context = new HashWardenDbContext())
                    {
                        _savedPassword = await context.Passwords
                            .Include(p => p.Folder)
                            .FirstOrDefaultAsync(p => p.Id == _savedPassword.Id);

                        if (_savedPassword == null)
                            throw new Exception();

                        LoadRecord();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Nie udało się wczytać wpisu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
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
                        await context.SaveChangesAsync();
                    }

                    MessageBox.Show("Usunięto wpis.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await Utils.ReloadData();
                    this.Close();
                }
            }
            // Wyłapanie błędu sterownika
            catch(Npgsql.NpgsqlException ex)
            {
                MessageBox.Show("Usunięto wpis.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Utils.ReloadData();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd przy usuwaniu wpisu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
