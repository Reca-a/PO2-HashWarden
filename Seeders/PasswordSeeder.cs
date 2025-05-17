using HashWarden.Data;

namespace HashWarden.Seeders
{
    public static class PasswordSeeder
    {
        public static void Seed(HashWardenDbContext context)
        {
            if (context.Passwords.Any()) return;

            var users = context.Users.ToList();
            if (!users.Any() || users.Count < 2) return;

            var folders = context.Folders.ToList();

            string[,] sites = { 
                { "facebook.com", "google.com", "instagram.com", "ur.edu.pl" },
                { "google.com", "github.com", "facebook.com", "company.net" }
            };

            string[] masterPassword = { "123", "TrudneHaslo" };

            var passwords = new List<Password>();

            Random random = new Random();

            using (var aes = System.Security.Cryptography.Aes.Create()) {
                for (int userIndex = 0; userIndex < sites.GetLength(0); userIndex++)
                {
                    var userFolders = folders.Where(f => f.UserId == users[userIndex].Id).ToList();

                    for (int siteIndex = 0; siteIndex < sites.GetLength(1); siteIndex++)
                    {
                        var title = sites[userIndex, siteIndex].Split(".")[0];
                        var randomDate = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(random.Next(-25, 0)));

                        string plainPassword = "zaq1";
                        byte[] key = EncryptionProvider.GenerateKeyFromPassword(masterPassword[userIndex], users[userIndex].Salt);

                        aes.Key = key;
                        aes.GenerateIV();
                        byte[] iv = aes.IV;
                        byte[] encrypted = EncryptionProvider.Encrypt(plainPassword, key, iv);

                        var password = new Password
                        {
                            UserId = users[userIndex].Id,
                            FolderId = userFolders[siteIndex % 2].Id,
                            Title = char.ToUpper(title[0]) + title.Substring(1),
                            ServiceName = sites[userIndex, siteIndex],
                            EncryptedPassword = encrypted,
                            Iv = iv,
                            CreatedAt = randomDate,
                            UpdatedAt = randomDate
                        };

                        passwords.Add(password);
                    }
                }
            }

            context.Passwords.AddRange(passwords);
            context.SaveChanges();
        }
    }
}
