using HashWarden.Data;
using System.Text.RegularExpressions;

namespace HashWarden.Forms.Dialogs
{
    public partial class AddFolderForm : Form
    {
        private string _folderName;
        private int _loggedUserId;

        public AddFolderForm(int loggedUserId)
        {
            _loggedUserId = loggedUserId;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public string GetFolderName()
        {
            return _folderName;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var folderName = NameInput.Text.Trim();
            var nameRegex = new Regex(@"^[a-zA-Z0-9 ]{1,49}$");
            if (!nameRegex.IsMatch(folderName))
            {
                MessageBox.Show("Nieprawidłowa nazwa folderu. Użyj liter (A-Z), liczb (0-9) oraz spacji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new HashWardenDbContext())
            {
                if (context.Folders.Any(f => f.FolderName == folderName && f.UserId == _loggedUserId))
                {
                    MessageBox.Show("Folder o takiej nazwie już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            _folderName = folderName;
            this.DialogResult = DialogResult.OK;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
