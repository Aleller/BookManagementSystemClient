using BookManagementSystemClient.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BookManagementSystemClient.ChildWindow
{
    public partial class Form_borrowHistory : Form
    {
        private Client client;

        public Form_borrowHistory(Client client)
        {
            InitializeComponent();

            this.client = client;
        }

        private void GetBorrowHistory()
        {
            string token = client.GetToken();
            token = token.Replace("+", "%2B");
            string id = client.GetUserName();

            HttpHandler httpHandler = new HttpHandler();

            string url = "http://45.77.191.48:7575/borrow/history";
            string sendString = "token=" + token + "&id=" + id;
            string returnString = httpHandler.HttpGet(url, sendString);
            Console.WriteLine(returnString);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic returnStringContent = js.Deserialize<dynamic>(returnString);
            string status = returnStringContent["status"];
            object[] recordObject = returnStringContent["record"];

            //请求数据完成，显示数据
            if (status == "successful")
            {
                for (int i = 0; i < recordObject.Length; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = (string)(recordObject[i]);
                }
            }
        }

        private void button_reflash_Click(object sender, EventArgs e)
        {
            this.GetBorrowHistory();
        }
    }
}
