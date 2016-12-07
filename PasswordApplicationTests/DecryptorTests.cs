using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace PasswordApplicationTests
{
    [TestClass]
    public class DecryptorTests
    {
        [TestMethod]
        public void AESDecrypt256Test()
        {
            Decryptor decryptor = new Decryptor();

            string str1 = decryptor.AESDecrypt256("vg2Ut0g/I5nnXxqn2v6/JQ==");

            string Key = "1234567890";

            // Declare Rijndael class 
            RijndaelManaged RinjindaelCipher = new RijndaelManaged();

            byte[] EncryptedData = Convert.FromBase64String("vg2Ut0g/I5nnXxqn2v6/JQ==");
            byte[] Salt = Encoding.ASCII.GetBytes(Key.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Key, Salt);

            // Create Decryptor object
            ICryptoTransform Decryptor = RinjindaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream(EncryptedData);

            // Create CryptoStream to read data
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

            // Declare array to store data decrypted
            byte[] PlainText = new byte[EncryptedData.Length];

            // The process of encryption
            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

            Assert.AreEqual(str1, DecryptedData);
        }
    }
}
