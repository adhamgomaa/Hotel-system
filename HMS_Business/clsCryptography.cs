using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class clsCryptography
    {
        public static string Hashing(string text)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashByte).Replace("-", "").ToLower();
            }
        }
        //public static string Hashing(string text)
        //{
        //    using (var deriveBytes = new Rfc2898DeriveBytes(text, 16, 100_000))
        //    {
        //        byte[] salt = deriveBytes.Salt;
        //        byte[] key = deriveBytes.GetBytes(32);

        //        return Convert.ToBase64String(salt) + "|" +
        //               Convert.ToBase64String(key);
        //    }
        //}

        //private static bool SlowEquals(byte[] a, byte[] b)
        //{
        //    if (a.Length != b.Length)
        //        return false;

        //    int diff = 0;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        diff |= a[i] ^ b[i];
        //    }
        //    return diff == 0;
        //}

        //public static bool VerifyPassword(string password, string storedHash)
        //{
        //    var parts = storedHash.Split('|');
        //    byte[] salt = Convert.FromBase64String(parts[0]);
        //    byte[] storedKey = Convert.FromBase64String(parts[1]);

        //    using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, 100_000))
        //    {
        //        byte[] newKey = deriveBytes.GetBytes(32);
        //        return SlowEquals(newKey, storedKey);
        //    }
        //}

        public static (string cipherText, string ivBase64) SymmetricEncrypt(string plainText, string base64Key)
        {
            byte[] keyBytes = Convert.FromBase64String(base64Key);
            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.GenerateIV(); // Random IV
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    return (Convert.ToBase64String(ms.ToArray()), Convert.ToBase64String(aes.IV));
                }
            }
        }

        public static string SymmetricDecrypt(string cipherText, string base64Key, string ivBase64)
        {
            byte[] keyBytes = Convert.FromBase64String(base64Key);
            byte[] ivBytes = Convert.FromBase64String(ivBase64);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = ivBytes;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
