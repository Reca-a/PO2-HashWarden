using System.Text;
using System.Security.Cryptography;
using Konscious.Security.Cryptography;

namespace HashWarden
{
    class EncryptionProvider
    {
        public static byte[] GenerateKeyFromPassword(string masterPassword, byte[] salt)
        {
            using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(masterPassword)))
            {
                argon2.Salt = salt;
                // Zoptymalizowane wartości dla Argon2
                argon2.DegreeOfParallelism = Math.Min(4, Environment.ProcessorCount);  // liczba wątków
                argon2.MemorySize = 64 * 1024;                                         // Ilość udostępnionej pamięci w KB
                argon2.Iterations = 4;                                                 // liczba iteracji

                return argon2.GetBytes(32);
            }
        }

        public static byte[] Encrypt(string plainText, byte[] key, byte[] iv)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                using (var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (var swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[16];
            RandomNumberGenerator.Fill(salt);
            return salt;
        }

        public static string Decrypt(byte[] encryptedText, byte[] key, byte[] iv)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                using (var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (var msDecrypt = new MemoryStream(encryptedText))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }
    }
}
