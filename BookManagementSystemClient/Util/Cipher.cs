using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystemClient.Util
{
    static class Cipher
    {
        //自动联网获取publickey，加密
        public static string AutoEncrypt(string plaintext)
        {
            //先获得publickeyConent
            string publickeyContent;
            string url = "http://45.77.191.48:7575/public";
            HttpHandler httpHandler = new HttpHandler();
            publickeyContent = httpHandler.HttpGet(url, "");

            //对plaintext进行加密
            RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
            string publickeyXml = Cipher.ConvertToXmlPublicJavaKey(RSAalg, publickeyContent);
            string ciphertext = Cipher.EncryptByRSA(plaintext, publickeyXml);

            Console.WriteLine("plaintext=" + plaintext);
            Console.WriteLine("publicKey=" + publickeyContent);
            Console.WriteLine("ciphertext=" + ciphertext);

            return ciphertext;
        }

        public static string EncryptByRSA(string plaintext, string publicKey)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(plaintext);
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKey);
                byte[] encryptedData = RSA.Encrypt(dataToEncrypt, false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string ConvertToXmlPublicJavaKey(this RSA rsa, string publicJavaKey)
        {
            RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicJavaKey));
            string xmlpublicKey = string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>",
            Convert.ToBase64String(publicKeyParam.Modulus.ToByteArrayUnsigned()),
            Convert.ToBase64String(publicKeyParam.Exponent.ToByteArrayUnsigned()));
            return xmlpublicKey;
        }
    }
}