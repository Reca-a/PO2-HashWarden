using HashWarden.Data;

namespace HashWarden.Seeders
{
    public static class FolderSeeder
    {
        public static void Seed(HashWardenDbContext context)
        {
            if (context.Folders.Any()) return;

            var users = context.Users.ToList();
            if (!users.Any()) return;


            var folders = new List<Folder>
            {
                new Folder
                {
                    UserId = users[0].Id,
                    FolderName = "Social media"
                },
                new Folder
                {
                    UserId = users[0].Id,
                    FolderName = "Inne"
                },
                new Folder
                {
                    UserId = users[1].Id,
                    FolderName = "Osobiste"
                },
                new Folder
                {
                    UserId = users[1].Id,
                    FolderName = "Praca"
                },
            };

            context.Folders.AddRange(folders);
            context.SaveChanges();
        }
    }
}
