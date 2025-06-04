using HashWarden.Helpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HashWarden.Forms.Dialogs
{
    public partial class MasterPasswordForm : Form
    {
        public MasterPasswordForm()
        {
            InitializeComponent();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            string password = PasswordInput.Text.Trim();

            if (Utils.VerifyMasterPassword(password))
            {
                byte[] key = EncryptionProvider.GenerateKeyFromPassword(password, Utils.LoggedUser.Salt);
                SessionKeyManager.SetKey(key, SessionKeyManager.GetAppliedTimeout());
                this.DialogResult = DialogResult.OK;
            }
        }

        public string GetPassword()
        {
            return PasswordInput.Text.Trim();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz anulować akcję?\nJeśli naciśniesz Tak, zostaniesz wylogowany.",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ProceedButton_Click(sender, e);
            }
        }
    }
}
