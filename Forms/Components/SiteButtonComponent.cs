using HashWarden.Data;
using HashWarden.Helpers;

namespace HashWarden.Forms.Components
{
    public partial class SiteButtonComponent : UserControl
    {
        private Password _savedPassword;

        public event EventHandler<Password> SiteClicked;

        public SiteButtonComponent(Password savedPassword)
        {
            this._savedPassword = savedPassword;
            InitializeComponent();
            this.SiteButton.Text = savedPassword.Title;

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Otwórz", null, SiteButton_Click);
            contextMenu.Items.Add("Usuń", null, Delete_Click);

            this.ContextMenuStrip = contextMenu;
        }

        private void SiteButton_Click(object sender, EventArgs e)
        {
            SiteClicked?.Invoke(this, _savedPassword);
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show(
                $"Czy na pewno chcesz usunąć wpis ze strony \"{_savedPassword.ServiceUrl}\" wraz z jego zawartością?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (confirm == DialogResult.No)
                    return;

                using (var context = new HashWardenDbContext())
                {
                    context.Passwords.Remove(_savedPassword);

                    await context.SaveChangesAsync();
                }
                await Utils.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania wpisu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
