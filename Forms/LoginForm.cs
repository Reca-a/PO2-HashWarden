using HashWarden.Data;
using HashWarden.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace HashWarden
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void MinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var email = EmailInput.Text.Trim();
            var password = PasswordInput.Text;

            // Weryfikacja emaila
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Nieprawidłowy format adresu email.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new HashWardenDbContext())
            {
                var user = await context.Users
                        .Include(u => u.Folders)
                        .Include(u => u.Passwords)
                        .FirstOrDefaultAsync(u => u.Email == email);

                if (user == null)
                {
                    MessageBox.Show("Nieprawidłowy email lub hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Weryfikacja hasła
                byte[] key = EncryptionProvider.GenerateKeyFromPassword(password, user.Salt);
                byte[] enteredHash = EncryptionProvider.Encrypt(password, key, user.Iv);

                if (enteredHash.SequenceEqual(user.MasterHash))
                {
                    Utils.LoggedUser = user;
                    SessionKeyManager.SetKey(key, TimeSpan.FromMinutes(10));
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy email lub hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void RegisterFormButton_click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            this.Hide();
            if (registerForm.ShowDialog() == DialogResult.OK || registerForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
