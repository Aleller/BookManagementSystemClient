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
    public partial class Form_orderInformation : Form
    {
        Client client;

        public Form_orderInformation(Client client)
        {
            InitializeComponent();

            this.client = client;

            this.GetReserveInformation();
        }

        private void button_reserve_Click(object sender, EventArgs e)
        {
            this.ReserveBook();
        }

        private void ReserveBook()
        {
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");
            string CallNumber = textBox_CallNumber.Text.Trim();

            string url = "http://45.77.191.48:7575/reserve/apply";

            HttpHandler httpHandler = new HttpHandler();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", id);
            dic.Add("token", token);
            dic.Add("callNumber", CallNumber);
            string returnString = httpHandler.HttpPost(url, dic);
        }

        private void GetReserveInformation()
        {
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");
            string url = "http://45.77.191.48:7575/reserve/history";
            string sendString = "id=" + id + "&token=" + token;

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpGet(url, sendString);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic returnStringContent = js.Deserialize<dynamic>(returnString);
            string status = returnStringContent["status"];

            if (status == "successful")
            {
                object[] record = returnStringContent["record"];
                for (int i = 0; i < record.Length; i++)
                {
                    dynamic dic = record[i] as Dictionary<string, object>;
                    ListViewItem item = new ListViewItem();
                    item.Text = "取消预约";
                    item.SubItems.Add(dic["callNumber"]);
                    item.SubItems.Add(dic["barcode"]);
                    item.SubItems.Add(dic["title"]);
                    item.SubItems.Add(dic["author"]);
                    item.SubItems.Add(dic["reserveDate"]);
                    item.SubItems.Add(dic["expiration"]);
                    item.SubItems.Add(dic["holding"]);
                    item.SubItems.Add(dic["status"]);

                    listView_orderInformation.Items.Add(item);
                }
            }
        }

        private void listView_orderInformation_ItemActivate(object sender, EventArgs e)
        {
            this.CancelReserve();
        }

        private void CancelReserve()
        {
            string url = "http://45.77.191.48:7575/reserve/delete";
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");

            ListView.SelectedIndexCollection c = listView_orderInformation.SelectedIndices;
            string CallNumber = listView_orderInformation.Items[c[0]].SubItems[1].Text;
            string Barcode = listView_orderInformation.Items[c[0]].SubItems[2].Text;

            HttpHandler httpHandler = new HttpHandler();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", id);
            dic.Add("token", token);
            dic.Add("callNumber", CallNumber);
            dic.Add("barcode", Barcode);

            string returnString = httpHandler.HttpPost(url, dic);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic returnStringContent = js.Deserialize<dynamic>(returnString);
            string status = returnStringContent["status"];

            if(status == "successful")
            {
                MessageBox.Show("取消成功");
            }

            this.GetReserveInformation();
        }
    }
}
