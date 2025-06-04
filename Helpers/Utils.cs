using HashWarden.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace HashWarden.Helpers
{
    static class Utils
    {
        private static User? _user;

        public static User? LoggedUser 
        { 
            get => _user;
            set
            {
                if (_user != value)
                {
                    _user = value;
                    LoggedUserRefreshed?.Invoke(true);
                }
            } 
        }

        public static event Action<bool>? LoggedUserRefreshed;

        public static void SetLoggedUser(User user)
        {
            LoggedUser = user;
        }

        public static async Task ReloadData()
        {
            if (LoggedUser == null)
                return;

            using (var context = new HashWardenDbContext())
            {
                var user = await context.Users
                    .Include(u => u.Folders)
                    .Include(u => u.Passwords)
                    .FirstOrDefaultAsync(u => u.Id == LoggedUser.Id);

                if (user != null)
                    LoggedUser = user;
            }
        }

        public static bool VerifyMasterPassword(string password)
        {
            byte[] key = EncryptionProvider.GenerateKeyFromPassword(password, LoggedUser.Salt);
            byte[] enteredHash = EncryptionProvider.Encrypt(password, key, LoggedUser.Iv);

            if (!enteredHash.SequenceEqual(LoggedUser.MasterHash))
            {
                MessageBox.Show("Nieprawidłowe hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static string CreateTitleFromUrl(string text)
        {
            if (text.StartsWith("www.")) text = text.Substring(4);
            var title = text.Split(".")[0];
            return char.ToUpper(title[0]) + title.Substring(1);
        }

        public static bool PasswordValidation(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 5)
            {
                MessageBox.Show("Hasło musi mieć co najmniej 5 znaków.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var hasUpper = password.Any(char.IsUpper);
            var hasLower = password.Any(char.IsLower);
            var hasDigit = password.Any(char.IsDigit);
            var passwordRegex = new Regex(@"[!@#$%^&*]");

            if (!(hasUpper && hasLower && hasDigit && passwordRegex.IsMatch(password)))
            {
                MessageBox.Show("Hasło musi zawierać duże i małe litery, cyfry oraz jeden znak specjalny (!, @, #, $, %, ^, *).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
