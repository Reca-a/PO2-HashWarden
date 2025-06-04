using HashWarden.Data;
using HashWarden.Helpers;

namespace HashWarden
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Task.Run(async () =>
            {
                try
                {
                    using (var context = new HashWardenDbContext())
                    {
                        if(!context.Users.Any() || !context.Folders.Any() || !context.Passwords.Any())
                        {
                            await DbInitializer.Initialize(context);
                            MessageBox.Show("Zainicjalizowano bazê");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas inicjalizacji bazy danych: {ex.Message}");
                }
            });

            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}