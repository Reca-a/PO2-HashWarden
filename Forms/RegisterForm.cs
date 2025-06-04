using HashWarden.Data;
using HashWarden.Helpers;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace HashWarden
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginFormButton_click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            var email = EmailInput.Text.Trim();
            var password = PasswordInput.Text;
            var passwordRepeat = PasswordRepeatInput.Text;

            // Walidacja emaila
            if (string.IsNullOrWhiteSpace(email) || email.Length > 40)
            {
                MessageBox.Show("E-mail nie może być pusty i musi mieć mniej niż 40 znaków.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Nieprawidłowy format adresu e-mail.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Walidacja hasła
            if (!Utils.PasswordValidation(password))
                return;

            if (password != passwordRepeat)
            {
                MessageBox.Show("Wpisane hasła muszą się zgadzać", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new HashWardenDbContext())
            {
                if (await context.Users.AnyAsync(u => u.Email == email))
                {
                    MessageBox.Show("Użytkownik z tym adresem e-mail już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] salt;
                byte[] key;
                byte[] iv;
                byte[] encrypted;

                using (var aes = System.Security.Cryptography.Aes.Create())
                {
                    salt = EncryptionProvider.GenerateSalt();
                    key = EncryptionProvider.GenerateKeyFromPassword(password, salt);

                    aes.Key = key;
                    aes.GenerateIV();
                    iv = aes.IV;
                    encrypted = EncryptionProvider.Encrypt(password, key, iv);
                }

                var user = new User
                {
                    Email = email,
                    Salt = salt,
                    Iv = iv,
                    MasterHash = encrypted,
                    CreatedAt = DateOnly.FromDateTime(DateTime.UtcNow)
                };

                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();

                MessageBox.Show("Rejestracja zakończona sukcesem", "Zarejestrowano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                RegisterButton_Click(sender, e);
            }
        }
    }
}
