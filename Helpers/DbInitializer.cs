using HashWarden.Data;
using HashWarden.Seeders;
namespace HashWarden.Helpers
{
    public static class DbInitializer
    {
        public static async Task Initialize(HashWardenDbContext context) {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    await UserSeeder.Seed(context);

                    await FolderSeeder.Seed(context);

                    await PasswordSeeder.Seed(context);

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Błąd przy seedowaniu bazy");
                }
            }
        }
    }
}
