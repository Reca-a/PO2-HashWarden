using HashWarden.Data;

namespace HashWarden.Seeders
{
    public static class UserSeeder
    {
        public static void Seed(HashWardenDbContext context)
        {
            if (context.Users.Any()) return;


            string[] masterPasswords = { "123", "TrudneHaslo"};
            var salts = new List<byte[]>();
            byte[] key;
            byte[] iv;
            var encrypted = new List<byte[]>();

            using (var aes = System.Security.Cryptography.Aes.Create())
            {

                for (int i = 0; i < masterPasswords.Length; i++) {
                    salts.Add(EncryptionProvider.GenerateSalt());
                    key = EncryptionProvider.GenerateKeyFromPassword(masterPasswords[i], salts[i]);

                    aes.Key = key;
                    aes.GenerateIV();
                    iv = aes.IV;
                    encrypted.Add(EncryptionProvider.Encrypt(masterPasswords[i], key, iv));
                }

            }
            var users = new List<User>
            {
                new User
                {
                    Email = "jan@example.com",
                    Salt = salts[0],
                    MasterHash = encrypted[0],
                    CreatedAt = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(-28))
                },
                new User
                {
                    Email = "karol@example.com",
                    Salt = salts[1],
                    MasterHash = encrypted[1],
                    CreatedAt = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(-33))
                }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
