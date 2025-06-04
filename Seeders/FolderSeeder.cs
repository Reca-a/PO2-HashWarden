using HashWarden.Data;
using Microsoft.EntityFrameworkCore;

namespace HashWarden.Seeders
{
    public static class FolderSeeder
    {
        public static async Task Seed(HashWardenDbContext context)
        {
            if (await context.Folders.AnyAsync()) 
                return;

            var users = await context.Users.ToListAsync();
            if (!users.Any()) 
                return;


            var folderNames = new Dictionary<int, string[]>
            {
                [0] = ["Social media", "Inne", "Banking", "Shopping", "Praca"],
                [1] = ["Osobiste", "Praca", "Finanse", "Rozrywka", "Edukacja"],
            };

            var folders = new List<Folder>();

            for (int userIndex = 0; userIndex < users.Count; userIndex++)
            {
                var userFolderNames = folderNames.GetValueOrDefault((userIndex % 2),
                    ["Social media", "Inne", "Banking", "Shopping", "Praca"]);

                foreach (var folderName in userFolderNames)
                {
                    folders.Add(new Folder
                    {
                        UserId = users[userIndex].Id,
                        FolderName = folderName
                    });
                }
            }

            await context.Folders.AddRangeAsync(folders);
            await context.SaveChangesAsync();
        }
    }
}
