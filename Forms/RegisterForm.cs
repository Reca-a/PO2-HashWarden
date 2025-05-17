using HashWarden.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashWarden
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginFormButton_click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(password) || password.Length < 5)
            {
                MessageBox.Show("Hasło musi mieć co najmniej 5 znaków.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var passwordRegex = new Regex(@"[!@#$%^&*(),.?""{}|<>]");
            if (!passwordRegex.IsMatch(password))
            {
                MessageBox.Show("Hasło musi zawierać przynajmniej jeden znak specjalny (!@#$% itp.).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != passwordRepeat)
            {
                MessageBox.Show("Wpisane hasła muszą się zgadzać", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new HashWardenDbContext())
            {
                if (context.Users.Any(u => u.Email == email))
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

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Rejestracja zakończona sukcesem", "Zarejestrowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
