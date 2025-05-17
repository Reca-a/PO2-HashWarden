namespace HashWarden
{
    public partial class SavedPasswordForm : Form
    {
        public SavedPasswordForm()
        {
            InitializeComponent();
        }

        private void ViewPassButton_Click(object sender, EventArgs e)
        {
            //TODO logika wyświetlania i chowania hasła
            if (this.ViewPassButton.ImageIndex == 0)
                this.ViewPassButton.ImageIndex = 1;
            else
                this.ViewPassButton.ImageIndex = 0;
        }
    }
}
