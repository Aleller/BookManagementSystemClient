using BookManagementSystemClient.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Script.Serialization;

namespace BookManagementSystemClient
{
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
                string url = "http://45.77.191.48:9090/login/submit";
                string data = "studentID=" + userName + "&" + "password=" + password;

                //发送并接收json
                HttpHandler httpHandler = new HttpHandler();
                string retStr = httpHandler.HttpPost(url, data);

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
    }
}
