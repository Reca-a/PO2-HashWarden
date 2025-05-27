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

            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}