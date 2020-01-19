using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionDecryption
{
    public static class Decryption
    {
        public static string Decrypt(string TextToDecrypt, string DecryptKey)
        {
            TextToDecrypt = TextToDecrypt.Replace(" ", "+");
            byte[] bytesBuff = Convert.FromBase64String(TextToDecrypt);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(DecryptKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    TextToDecrypt = Encoding.Unicode.GetString(mStream.ToArray());
                }
            }
            return TextToDecrypt;
        }
    }
}
