using HashWarden.Data;
using HashWarden.Helpers;
using System.Windows.Forms;

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

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Otwórz", null, FolderButton_Click);
            contextMenu.Items.Add("Usuń", null, Delete_Click);

            this.ContextMenuStrip = contextMenu;
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            FolderClicked?.Invoke(this, _linkedFolder);
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show(
                $"Czy na pewno chcesz usunąć folder \"{_linkedFolder.FolderName}\" wraz z jego zawartością?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (confirm == DialogResult.No)
                    return;

                using (var context = new HashWardenDbContext())
                {
                    context.Passwords.RemoveRange(_linkedFolder.Passwords);
                    context.Folders.Remove(_linkedFolder);

                    await context.SaveChangesAsync();
                }
                await Utils.ReloadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania folderu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
