namespace HashWarden.Forms.Components
{
    public partial class SiteButtonComponent : UserControl
    {
        private Password savedPassword;

        public event EventHandler<Password> SiteClicked;

        public SiteButtonComponent(Password savedPassword)
        {
            this.savedPassword = savedPassword;
            InitializeComponent();
            this.SiteButton.Text = savedPassword.Title;
        }

        private void SiteButton_Click(object sender, EventArgs e)
        {
            SiteClicked?.Invoke(this, savedPassword);
        }
    }
}
