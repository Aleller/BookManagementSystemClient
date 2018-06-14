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
    public partial class Form_reserveBooks : Form
    {
        private Client client;

        public Form_reserveBooks(Client client, string result)
        {
            InitializeComponent();

            this.client = client;

            this.ShowResultOnListView(result);
        }

        private void ShowResultOnListView(string result_str)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic resultContent = js.Deserialize<dynamic>(result_str);

            string status = resultContent["status"];
            object[] result = resultContent["result"];

            if(status == "successful")
            {
                for (int i = 0; i < result.Length; i++)
                {
                    dynamic dic = result[i] as Dictionary<string, object>;
                    ListViewItem item = new ListViewItem();
                    item.Text = "预约";
                    item.SubItems.Add(dic["marcNo"]);
                    item.SubItems.Add(dic["callNumber"]);
                    item.SubItems.Add(dic["barcode"]);
                    item.SubItems.Add(dic["volume"]);
                    item.SubItems.Add(dic["holding"]);
                    item.SubItems.Add(dic["status"]);
                    item.SubItems.Add(dic["returning"]);

                    listView_holdingInformation.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("显示馆藏信息出错");
            }
        }

        private void listView_holdingInformation_ItemActivate(object sender, EventArgs e)
        {
            this.ReserveBook();
        }

        private void ReserveBook()
        {
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");
            ListView.SelectedIndexCollection collection = listView_holdingInformation.SelectedIndices;
            string CallNumber = listView_holdingInformation.Items[collection[0]].SubItems[2].Text;

            string url = "http://45.77.191.48:7575/reserve/apply";

            HttpHandler httpHandler = new HttpHandler();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", id);
            dic.Add("token", token);
            dic.Add("callNumber", CallNumber);
            string returnString = httpHandler.HttpPost(url, dic);

            MessageBox.Show("预约成功");
            this.Close();
        }
    }
}
