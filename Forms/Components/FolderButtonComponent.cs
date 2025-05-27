namespace HashWarden.Forms.Components
{
    public partial class FolderButtonComponent : UserControl
    {
        private Folder _linkedFolder;

        public event EventHandler<Folder> FolderClicked;

        public FolderButtonComponent(Folder folder)
        {
            this._linkedFolder = folder;
            InitializeComponent();
            this.FolderButton.Text = "   " + folder.FolderName;
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            FolderClicked?.Invoke(this, _linkedFolder);
        }
    }
}
