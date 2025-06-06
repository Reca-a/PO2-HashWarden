using HashWarden.Data;
using HashWarden.Helpers;
using Microsoft.EntityFrameworkCore;
namespace HashWarden.Forms.Dialogs
{
    public partial class ConnectionStringForm : Form
    {
        public ConnectionStringForm()
        {
            InitializeComponent();
            StringInput.Text = AppConfiguration.GetConnectionString();
        }

        private async void ChangeButton_Click(object sender, EventArgs e)
        {
            string newConn = StringInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(newConn))
            {
                MessageBox.Show("Connection string nie może być pusty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<HashWardenDbContext>();
                optionsBuilder.UseNpgsql(newConn);

                using (var context = new HashWardenDbContext(optionsBuilder.Options))
                {
                    if (!await context.Database.CanConnectAsync())
                        throw new Exception("Nie można połączyć się z bazą danych");
                }

                AppConfiguration.SetConnectionString(newConn);

                MessageBox.Show("Połączenie zostało zmienione i jest prawidłowe.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Utils.ReloadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia: {ex.Message}.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ChangeButton_Click(sender, e);
            }
        }
    }
}
