using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Encryption
    {
        // https://qawithexperts.com/article/c-sharp/encrypt-password-decrypt-it-c-console-application-example/169

        private const string EncryptionKey = "J9MTHM8xHJgB4UM0RovmwRP0yfYT6kQw";

        public string EncryptPlainText(string plainText)
        {
            byte[] toEncryptedArray = Encoding.UTF8.GetBytes(plainText);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encryptionKeyArray = md5.ComputeHash(Encoding.UTF8.GetBytes(EncryptionKey));
            md5.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();

            objTripleDESCryptoService.Key = encryptionKeyArray;
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var objCryptoTransform = objTripleDESCryptoService.CreateEncryptor();
            byte[] encryptedArray = objCryptoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);
            objTripleDESCryptoService.Clear();

            return Convert.ToBase64String(encryptedArray, 0, encryptedArray.Length);
        }


        public string DecryptPassword(string clipherText)
        {
            byte[] toEncryptArray = Convert.FromBase64String(clipherText);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encryptionKeyArray = md5.ComputeHash(Encoding.UTF8.GetBytes(EncryptionKey));
            md5.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();

            objTripleDESCryptoService.Key = encryptionKeyArray;
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var objCryptoTransform = objTripleDESCryptoService.CreateDecryptor();
            byte[] decryptedArray = objCryptoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            objTripleDESCryptoService.Clear();

            return Encoding.UTF8.GetString(decryptedArray);
        }

    }
}
