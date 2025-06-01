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

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string newConn = StringInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(newConn))
            {
                MessageBox.Show("Connection string nie może być pusty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<HashWardenDbContext>();
                optionsBuilder.UseNpgsql(newConn);

                using (var context = new HashWardenDbContext(optionsBuilder.Options))
                {
                    if (!context.Database.CanConnect())
                        throw new Exception("Nie można połączyć się z bazą danych");
                }

                AppConfiguration.SetConnectionString(newConn);

                MessageBox.Show("Połączenie zostało zmienione i jest prawidłowe.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia: {ex.Message}.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
