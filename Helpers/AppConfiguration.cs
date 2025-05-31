using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace HashWarden.Helpers
{
    class AppConfiguration
    {
        private static readonly string _configFile = "appsettings.json";

        private static IConfigurationRoot _configuration;

        static AppConfiguration()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                string baseDirectory = AppContext.BaseDirectory;
                string configPath = Path.Combine(baseDirectory, "appsettings.json");

                if (!File.Exists(configPath))
                {
                    string projectDirectory = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", ".."));
                    configPath = Path.Combine(projectDirectory, "appsettings.json");

                    if (!File.Exists(configPath))
                    {
                        throw new FileNotFoundException($"Nie znaleziono pliku appsettings.json w ścieżkach:\n" +
                            $"- {Path.Combine(baseDirectory, "appsettings.json")}\n" +
                            $"- {configPath}");
                    }
                }
                _configuration = new ConfigurationBuilder()
                    .AddJsonFile(configPath, optional: false, reloadOnChange: true)
                    .Build();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wczytywania konfiguracji: {ex.Message}", "Błąd konfiguracji",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string? GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

        public static void SetConnectionString(string newConnectionString)
        {
            var json = File.ReadAllText(_configFile);

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement.Clone();

            var newJson = new Dictionary<string, object>();

            foreach (var element in root.EnumerateObject())
            {
                if (element.Name == "ConnectionStrings")
                {
                    newJson["ConnectionStrings"] = new Dictionary<string, string>
                {
                    { "DefaultConnection", newConnectionString }
                };
                }
                else
                {
                    newJson[element.Name] = element.Value;
                }
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string updatedJson = JsonSerializer.Serialize(newJson, options);

            File.WriteAllText(_configFile, updatedJson);
            Load();
        }
    }
}
