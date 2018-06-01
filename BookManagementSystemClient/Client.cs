using BookManagementSystemClient.Util;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Web.Script.Serialization;

namespace BookManagementSystemClient
{
    static class cipher
    {
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

    class Client
    {
        /// <summary>
        /// 使用http协议向服务器发送用户名和密码
        /// 根据接收到的登录结果返回true（登录成功）或者false（登录失败）
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string userName, string password)
        {
            try
            {
                //先获得publickeyConent
                String publickeyConent;
                string url = "http://45.77.191.48:7575/public";
                HttpHandler httpHandler = new HttpHandler();
                publickeyConent = httpHandler.HttpGet(url, "");

                //对发送的密码进行加密
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                string publickeyXml = cipher.ConvertToXmlPublicJavaKey(RSAalg, publickeyConent);
                string encryptedPassword = cipher.EncryptByRSA(password, publickeyXml);

                //..

                //发送并接收
                var dic = new Dictionary<string, string>();
                dic.Add("id", userName);
                dic.Add("pw", encryptedPassword);
                url = "http://45.77.191.48:7575/login";
                string retStr = httpHandler.HttpPost(url, dic);

                //解析json
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                dynamic retStrContent = serializer.Deserialize<dynamic>(retStr);
                string status = retStrContent["status"];

                if (status == "success")
                {
                    return true;
                }
                return false;
            }catch(Exception e)
            {
                throw e;
            }
        }

        public bool Register(string userName, string password)
        {
            return false;
        }
    }
}
