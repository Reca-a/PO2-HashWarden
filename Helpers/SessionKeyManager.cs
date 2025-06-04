using System.Security.Cryptography;

namespace HashWarden.Helpers
{
    static class SessionKeyManager
    {
        private static byte[] _key;
        private static TimeSpan _appliedTimeout;
        private static System.Threading.Timer _inactivityTimer;

        // Ustawienie klucza głównego i dopuszczalnego czasu nieaktywności
        public static void SetKey(byte[] key, TimeSpan timeout)
        {
            _key = key;
            _appliedTimeout = timeout;
            _inactivityTimer = new System.Threading.Timer(OnTimeout, null, _appliedTimeout, Timeout.InfiniteTimeSpan);
        }

        // Zresetowanie odliczania i zwrócenie klucza
        public static byte[]? GetKey()
        {
            ResetTimeout();
            return _key;
        }

        public static TimeSpan GetAppliedTimeout()
        {
            return _appliedTimeout;
        }

        public static void ClearKey()
        {
            // Wyczyszczenie pamięci (nadpisanie losowymi danymi przed wyczyszczeniem)
            if (_key != null)
            {
                var random = new byte[_key.Length];
                RandomNumberGenerator.Fill(random);
                Array.Copy(random, _key, _key.Length);
                Array.Clear(_key, 0, _key.Length);
            }

            _key = null;
            _inactivityTimer?.Dispose();
        }

        // Metoda wywoływana przy przekroczeniu czasu nieaktywności, otwiera okno, w którym należy ponownie podać główne hasło
        private static void OnTimeout(object? state)
        {
            ClearKey();
        }

        private static void ResetTimeout()
        {
            _inactivityTimer?.Change(_appliedTimeout, Timeout.InfiniteTimeSpan);
        }
    }
}
