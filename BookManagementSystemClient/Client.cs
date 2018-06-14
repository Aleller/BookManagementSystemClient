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
    public class Client
    {
        private string token;
        private string userName;

        /// <summary>
        /// 使用http协议向服务器发送用户名和密码
        /// 根据接收到的登录结果返回true（登录成功）或者false（登录失败）
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Dictionary<string,string> Login(string userName, string password, string userGroup)
        {
            try
            {
                //对发送的密码进行加密
                string encryptedPassword = Cipher.AutoEncrypt(password);

                //加号在经过传递后会变成空格，所以这里先转了
                userName = userName.Replace("+", "%2B");
                encryptedPassword = encryptedPassword.Replace("+", "%2B");

                //发送并接收
                var dic = new Dictionary<string, string>();
                dic.Add("id", userName);
                dic.Add("pw", encryptedPassword);
                dic.Add("ug", userGroup);
                string url = "http://45.77.191.48:7575/login";
                HttpHandler httpHandler = new HttpHandler();
                string retStr = httpHandler.HttpPost(url, dic);

                //解析json
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                dynamic retStrContent = serializer.Deserialize<dynamic>(retStr);
                string status = retStrContent["status"];
                string token = retStrContent["token"];

                
                if (status == "successful")
                {
                    this.userName = userName;
                    this.token = token;
                }

                Dictionary<string, string> returnDictionary = new Dictionary<string, string>();
                returnDictionary.Add("status", status);
                returnDictionary.Add("userGroup", userGroup);

                return returnDictionary;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw e;
            }
        }

        public bool Register(string userName, string password, string userGroup, string key)
        {
            //对发送的密码进行加密
            string encryptedPassword = Cipher.AutoEncrypt(password);

            //加号在经过传递后会变成空格，所以这里先转了
            userName = userName.Replace("+", "%2B");
            encryptedPassword = encryptedPassword.Replace("+", "%2B");

            //发送并接收
            var dic = new Dictionary<string, string>();
            dic.Add("id", userName);
            dic.Add("pw", encryptedPassword);
            dic.Add("ug", userGroup);
            dic.Add("key", key);
            string url = "";
            switch (userGroup)
            {
                case "reader":
                    url = "http://45.77.191.48:7575/register";
                    break;
                case "admin":
                    url = "http://45.77.191.48:7575/admin/register";
                    break;
            }
            HttpHandler httpHandler = new HttpHandler();
            string retStr = httpHandler.HttpPost(url, dic);
            /*考虑一下需不需要封装“发送并接收”的操作*/
            
            //解析json
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic retStrContent = serializer.Deserialize<dynamic>(retStr);
            string status = retStrContent["status"];

            if (status == "successful")
            {
                return true;
            }else
            {
                return false;
            }
            
        }

        public string GetToken()
        {
            return this.token;
        }

        public string GetUserName()
        {
            return userName;
        }
    }
}
