using HashWarden.Data;
using HashWarden.Seeders;
namespace HashWarden
{
    public static class DbInitializer
    {
        public static void Initialize(HashWardenDbContext context) {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    UserSeeder.Seed(context);

                    FolderSeeder.Seed(context);

                    PasswordSeeder.Seed(context);
                
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
