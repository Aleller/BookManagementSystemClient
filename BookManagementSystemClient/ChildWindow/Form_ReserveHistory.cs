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
    public partial class Form_ReserveHistory : Form
    {
        private Client client;

        public Form_ReserveHistory(Client client)
        {
            InitializeComponent();

            this.client = client;

            this.GetReserveHistory();
        }

        private void GetReserveHistory()
        {
            string url = "http://45.77.191.48:7575/reserve/history";
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");

            HttpHandler httpHandler = new HttpHandler();
            string sendString = "id=" + id + "&token=" + token;
            string returnString = httpHandler.HttpGet(url, sendString);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic returnStringContent = js.Deserialize<dynamic>(returnString);
            string status = returnStringContent["status"];

            if(status == "successful")
            {
                object[] record = returnStringContent["record"];

                for (int i = 0; i < record.Length; i++)
                {
                    dynamic dic = record[i] as Dictionary<string, object>;
                    ListViewItem item = new ListViewItem();
                    item.Text = dic["callNumber"];
                    item.SubItems.Add(dic["barcode"]);
                    item.SubItems.Add(dic["title"]);
                    item.SubItems.Add(dic["author"]);
                    item.SubItems.Add(dic["reserveDate"]);
                    item.SubItems.Add(dic["expiration"]);
                    item.SubItems.Add(dic["holding"]);
                    item.SubItems.Add(dic["status"]);

                    listView_borrowHistory.Items.Add(item);
                }
            }
        }
    }
}
