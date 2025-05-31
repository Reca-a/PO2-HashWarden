using HashWarden.Data;
using HashWarden.Helpers;
using HashWarden.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace HashWarden.Forms.Dialogs
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Zapis eksportowanych danych do pliku .json
        private async void ExportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                """
                Eksportowane dane są zapisywane w pliku ze zwykłym tekstem. 
                Po skończeniu korzystania z pliku zalecane jest jego usunięcie.
                """,
                "Uwaga",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            try
            {
                var export = ExportUserDataAsync(Utils.LoggedUser.Id);
                var filePath = AskUserForExportPath();

                var exportModel = await ExportUserDataAsync(Utils.LoggedUser.Id);
                var json = JsonSerializer.Serialize(exportModel, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                MessageBox.Show("Eksport zakończony pomyślnie.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Eksport haseł się nie powiódł: " + ex.Message,
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Import danych
        private async void ImportButton_Click(object sender, EventArgs e)
        {
            await ImportUserDataAsync(Utils.LoggedUser.Id);
        }

        // Przygotowanie eksportowanych danych
        public async Task<ExportModel> ExportUserDataAsync(int userId)
        {
            using (var context = new HashWardenDbContext())
            {
                var user = await context.Set<User>()
                .Include(u => u.Passwords)
                .Include(u => u.Folders)
                .FirstOrDefaultAsync(u => u.Id == userId);

                if (user == null)
                    throw new Exception("Nie znaleziono użytkownika.");

                var export = new ExportModel
                {
                    Passwords = user.Passwords.Select(p => new ExportPassword
                    {
                        Title = p.Title,
                        UserName = p.UserName,
                        ServiceUrl = p.ServiceUrl,
                        EncryptedPassword = Convert.ToBase64String(p.EncryptedPassword),
                        Iv = Convert.ToBase64String(p.Iv),
                        CreatedAt = p.CreatedAt,
                        UpdatedAt = p.UpdatedAt,
                        FolderName = p.Folder?.FolderName
                    }).ToList(),
                    Folders = user.Folders.Select(f => f.FolderName).ToList()
                };

                return export;
            }
        }

        // Okno dialogowe z wyborem ścieżki eksportu
        public string? AskUserForExportPath()
        {
            var dialog = new SaveFileDialog
            {
                FileName = $"HashWarden_export_{DateOnly.FromDateTime(DateTime.Now)}.json",
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                DefaultExt = ".json",
                Title = "Zapisz eksportowane dane"
            };

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                return dialog.FileName;
            else
                return null;
        }

        // Zapis importowanych danych do bazy
        public async Task ImportUserDataAsync(int userId)
        {
            using (var context = new HashWardenDbContext())
            {
                await using var transaction = await context.Database.BeginTransactionAsync();
                try
                {
                    var filePath = AskUserForImportPath();
                    if (filePath == null || !File.Exists(filePath))
                        throw new Exception("Nie wybrano pliku lub plik nie istnieje.");

                    var json = await File.ReadAllTextAsync(filePath);
                    var exportModel = JsonSerializer.Deserialize<ExportModel>(json);
                    if (exportModel == null)
                        throw new Exception("Nie udało się odczytać pliku.");

                    var user = await context.Users.FindAsync(userId);
                    if (user == null)
                        throw new Exception("Nie znaleziono użytkownika.");

                    if (exportModel.Passwords.Count == 0)
                    {
                        throw new Exception("Brak haseł w pliku.");
                    }

                    var existingFolders = await context.Folders
                        .Where(f => f.UserId == userId)
                        .ToListAsync();

                    var folderDict = existingFolders
                        .ToDictionary(f => f.FolderName, f => f, StringComparer.OrdinalIgnoreCase);

                    foreach (var folderName in exportModel.Folders.Distinct())
                    {
                        if (!folderDict.TryGetValue(folderName, out var folder))
                        {
                            folder = new Folder
                            {
                                UserId = userId,
                                FolderName = folderName
                            };
                            context.Folders.Add(folder);
                            folderDict[folderName] = folder;
                        }
                    }

                    await context.SaveChangesAsync();

                    var existingPasswords = await context.Passwords
                        .Where(p => p.UserId == userId)
                        .ToListAsync();
                    var existingPasswordSet = new HashSet<string>(
                        existingPasswords.Select(p => $"{p.UserName}|{p.ServiceUrl}")
                    );

                    foreach (var pwd in exportModel.Passwords)
                    {
                        // Klucz do rozpoznania powtarzającego się wpisu - nazwa użytkownika + adres strony
                        var key = $"{pwd.UserName}|{pwd.ServiceUrl}";

                        // Nadpisanie hasła
                        if (existingPasswordSet.Contains(key))
                        {
                            var result = MessageBox.Show(
                                $"""
                                Hasło do strony {pwd.ServiceUrl} dla użytkownika {pwd.UserName} już istnieje.
                                Czy chcesz je nadpisać?
                                """,
                                "Uwaga",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );

                            if (result == DialogResult.No)
                                continue;

                            var existing = existingPasswords.First(p =>
                                p.UserName == pwd.UserName &&
                                p.ServiceUrl == pwd.ServiceUrl
                            );

                            var importedPassword = Convert.FromBase64String(pwd.EncryptedPassword);
                            if (!importedPassword.SequenceEqual(existing.EncryptedPassword))
                            {
                                existing.EncryptedPassword = importedPassword;
                                existing.Iv = Convert.FromBase64String(pwd.Iv);
                                existing.UpdatedAt = pwd.UpdatedAt;
                            }
                            continue;
                        }

                        // Zapisanie nowego hasła
                        int? folderId;
                        if (pwd.FolderName != null && folderDict.TryGetValue(pwd.FolderName, out var folder))
                            folderId = folder.Id;
                        else
                            folderId = null;

                        context.Passwords.Add(new Password
                        {
                            UserId = userId,
                            FolderId = folderId,
                            Title = pwd.Title,
                            UserName = pwd.UserName,
                            ServiceUrl = pwd.ServiceUrl,
                            EncryptedPassword = Convert.FromBase64String(pwd.EncryptedPassword),
                            Iv = Convert.FromBase64String(pwd.Iv),
                            CreatedAt = pwd.CreatedAt,
                            UpdatedAt = pwd.UpdatedAt
                        });
                    }

                    await context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    MessageBox.Show("Import zakończony pomyślnie.");
                    await Utils.ReloadData();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();

                    MessageBox.Show(
                        "Import haseł się nie powiódł: " + ex.Message,
                        "Błąd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // Okno dialogowe z wyborem ścieżki importu
        public string? AskUserForImportPath()
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Wybierz plik do importu"
            };

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK && Path.GetExtension(dialog.FileName.ToLower()).Equals(".json"))
                return dialog.FileName;
            else
                return null;
        }

        private void ConnStringButton_Click(object sender, EventArgs e)
        {
            var dialog = new ConnectionStringForm();
            dialog.ShowDialog();
        }
    }
}
