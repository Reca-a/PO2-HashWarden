using HashWarden.Data;

namespace HashWarden
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Task.Run(() =>
            {
                try
                {
                    using (var context = new HashWardenDbContext())
                    {
                        DbInitializer.Initialize(context);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas inicjalizacji bazy danych: {ex.Message}");
                }
            });
            Application.Run(new LoginForm());
        }
    }
}