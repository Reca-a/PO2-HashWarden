using System.Security.Cryptography;

namespace HashWarden
{
    class PasswordManager
    {
        private string masterPassword;

        public PasswordManager(string masterPassword)
        {
            this.masterPassword = masterPassword;
        }

        public void SavePassword(string website, string plainPassword)
        {
            //Generowanie 'salt' dla hasła
            byte[] salt = EncryptionProvider.GenerateSalt();
            //Generowanie klucza szyfrującego z hasła głównego
            byte[] key = EncryptionProvider.GenerateKeyFromPassword(masterPassword, salt);

            //Generowanie losowego wektora inicjującego
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.GenerateIV();
                byte[] iv = aesAlg.IV;

                //Szyfrowanie hasła
                byte[] encryptedPassword = EncryptionProvider.Encrypt(plainPassword, key, iv);

                //TODO
                //SaveToDatabase(website, encryptedPassword, salt, iv);
            }
        }

        public string GetPassword(string website)
        {
            //TODO
            return null;
        }
    }
}
