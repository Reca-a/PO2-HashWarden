using HashWarden.Data;
using HashWarden.Helpers;
using Microsoft.EntityFrameworkCore;

namespace HashWarden.Seeders
{
    public static class PasswordSeeder
    {
        public static async Task Seed(HashWardenDbContext context)
        {
            if (await context.Passwords.AnyAsync()) 
                return;

            var users = await context.Users.ToListAsync();
            if (!users.Any() || users.Count < 2) 
                return;

            var folders = await context.Folders.ToListAsync();

            var sites = new Dictionary<int, string[]>
            {
                [0] = ["www.facebook.com", "www.google.com", "www.instagram.com", "www.ur.edu.pl", "www.github.com", "www.netflix.com", "www.spotify.com", "www.amazon.com"],
                [1] = ["www.google.com", "www.github.com", "www.facebook.com", "www.company.net", "www.linkedin.com", "www.stackoverflow.com", "www.youtube.com", "www.twitter.com"]
            };

            string[] masterPassword = { "123", "zaq1@WSX" };

            var passwords = new List<Password>();

            Random random = new Random();

            using (var aes = System.Security.Cryptography.Aes.Create()) {
                for (int userIndex = 0; userIndex < users.Count; userIndex++)
                {
                    var userFolders = folders.Where(f => f.UserId == users[userIndex].Id).ToList();

                    var siteNames = sites.GetValueOrDefault((userIndex % 2),
                        ["www.facebook.com", "www.google.com", "www.instagram.com", "www.ur.edu.pl", 
                        "www.github.com", "www.netflix.com", "www.spotify.com", "www.amazon.com"]).ToList();

                    foreach (var site in siteNames)
                    {
                        var randomDate = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(random.Next(-25, 0)));

                        string plainPassword = "zaq1@WSX";
                        byte[] key = EncryptionProvider.GenerateKeyFromPassword(masterPassword[userIndex], users[userIndex].Salt);

                        aes.Key = key;
                        aes.GenerateIV();
                        byte[] iv = aes.IV;
                        byte[] encrypted = EncryptionProvider.Encrypt(plainPassword, key, iv);

                        var password = new Password
                        {
                            UserId = users[userIndex].Id,
                            FolderId = userFolders[siteNames.IndexOf(site) % userFolders.Count].Id,
                            Title = Utils.CreateTitleFromUrl(site),
                            UserName = users[userIndex].Email,
                            ServiceUrl = site,
                            EncryptedPassword = encrypted,
                            Iv = iv,
                            CreatedAt = randomDate,
                            UpdatedAt = randomDate
                        };

                        passwords.Add(password);
                    }
                }
            }

            await context.Passwords.AddRangeAsync(passwords);
            await context.SaveChangesAsync();
        }
    }
}
