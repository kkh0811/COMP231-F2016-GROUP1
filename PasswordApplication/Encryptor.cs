using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace PasswordApplication
{
    public class Encryptor
    {
        // AES_256 Encryption
        public String AESEncrypt256(String InputText)
        {
            // the value of key will be changed in next iteration
            string Key = "1234567890";

            RijndaelManaged RinjindaelCipher = new RijndaelManaged();

            // Convert from String to Byte array
            Byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(InputText);

            // Make a difficult key to prevent from dictionary attack
            // Uses Salt
            byte[] Salt = Encoding.ASCII.GetBytes(Key.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Key, Salt);

            // Create a encryptor from the existing SecretKey bytes.
            // Create encryptor object from SecretKey
            // Secret Key ->  uses 32 bytes
            // Initialization Vector -> uses 16 bytes
            ICryptoTransform Encryptor = RinjindaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream();

            // Declare CryptoStream object to write data encrypted
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(PlainText, 0, PlainText.Length);
            cryptoStream.FlushFinalBlock();
            byte[] CipherBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();

            string EncryptedData = Convert.ToBase64String(CipherBytes);
            return EncryptedData;
        }
    }
}
