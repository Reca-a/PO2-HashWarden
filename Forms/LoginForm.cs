using HashWarden.Data;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (var context = new HashWardenDbContext())
            {
                var email = EmailInput.Text.Trim();
                var password = PasswordInput.Text;

                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!emailRegex.IsMatch(email))
                {
                    MessageBox.Show("Nieprawidłowy format adresu e-mail.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = context.Users.FirstOrDefault(u => u.Email == email);
                if (user == null)
                {
                    MessageBox.Show("Nieprawidłowy e-mail lub hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] key = EncryptionProvider.GenerateKeyFromPassword(password, user.Salt);
                byte[] enteredHash = EncryptionProvider.Encrypt(password, key, user.Iv);

                if (enteredHash.SequenceEqual(user.MasterHash))
                {
                    var mainForm = new MainForm(user);
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy e-mail lub hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void RegisterFormButton_click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
