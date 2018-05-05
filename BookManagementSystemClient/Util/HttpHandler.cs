using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystemClient.Util
{
    class HttpHandler
    {
        /// <summary>
        /// 向指定的url发送http表单，并返回json字符串
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postDataStr"></param>
        /// <returns></returns>
        public string HttpPost(string url, string postDataStr)
        {
            //用户名和密码先用明文传，有时间再考虑加密
            try
            {
                //发送
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
                Stream myRequestStream = request.GetRequestStream();
                StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
                myStreamWriter.Write(postDataStr);
                myStreamWriter.Close();

                //接收
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //response.Cookies = cookie.GetCookies(response.ResponseUri);
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
