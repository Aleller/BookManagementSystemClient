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

namespace BookManagementSystemClient
{
    public partial class Form_operationUI : Form
    {
        private Client client;

        public Form_operationUI(Client client)
        {
            InitializeComponent();

            this.client = client;

            this.GetBorrowInformation();

            this.GetInfo();

            this.GetAnnouncement();
        }

        private void GetAnnouncement()
        {
            HttpHandler httpHandler = new HttpHandler();

            string url = "http://45.77.191.48:7575/broadcast/get";
            string returnString = httpHandler.HttpGet(url, "");

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic returnStringContent = serializer.Deserialize<dynamic>(returnString);

            string message = returnStringContent["msg"];

            MessageBox.Show("通知：\n" + message);
        }

        private void 借阅历史ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_borrowHistory child = new ChildWindow.Form_borrowHistory(this.client);
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 预约信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_orderInformation child = new ChildWindow.Form_orderInformation(this.client);
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 检索历史ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_queryHistory child = new ChildWindow.Form_queryHistory();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 馆藏检索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_libraryQuery child = new ChildWindow.Form_libraryQuery(this.client);
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetBorrowInformation()
        {
            string url = "http://45.77.191.48:7575/borrow/now";
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
                    item.Text = "续借";
                    item.SubItems.Add(dic["barcode"]);
                    item.SubItems.Add(dic["title"]);
                    item.SubItems.Add(dic["author"]);
                    item.SubItems.Add(dic["borrowDate"]);
                    item.SubItems.Add(dic["returnDate"]);
                    item.SubItems.Add(dic["holding"]);
                    if (dic["isRenewed"])
                    {
                        item.SubItems.Add("是");
                    }else
                    {
                        item.SubItems.Add("否");
                    }


                    listView_borrowedBooks.Items.Add(item);
                }
            }
        }

        private void 预约历史toolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_ReserveHistory child = new ChildWindow.Form_ReserveHistory(this.client);
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView_borrowedBooks_ItemActivate(object sender, EventArgs e)
        {
            this.Renew();
        }

        private void Renew()
        {
            string url = "http://45.77.191.48:7575/borrow/renew";
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2b");

            ListView.SelectedIndexCollection c = listView_borrowedBooks.SelectedIndices;
            string Barcode = listView_borrowedBooks.Items[c[0]].SubItems[1].Text;

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", id);
            dic.Add("token", token);
            dic.Add("barcode", Barcode);

            HttpHandler httpHandler = new HttpHandler();

            string returnString = httpHandler.HttpPost(url, dic);

            listView_borrowedBooks.Items.Clear();

            this.GetBorrowInformation();
        }

        private void GetInfo()
        {
            string url = "http://45.77.191.48:7575/info";
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");
            string sendString = "id=" + id + "&token=" + token;

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpGet(url, sendString);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic returnStringContent = js.Deserialize<dynamic>(returnString);
            string status = returnStringContent["status"];

            if(status == "successful")
            {
                int hasBorrowed = listView_borrowedBooks.Items.Count;
                int hasReserved = this.GetReserveCount();

                //int hasBorrowed = returnStringContent["hasBorrowed"];
                //int hasReserved = returnStringContent["hasReserved"];
                int maxBorrow = returnStringContent["maxBorrow"];
                int maxReserve = returnStringContent["maxReserve"];

                label_maxBorrow.Text = "最多可借阅：" + maxBorrow.ToString();
                label_maxOrder.Text = "最多可预约：" + maxReserve.ToString();
                label_ordered.Text = "已预约：" + hasReserved.ToString();
                label_borrowedBookAmount.Text = "已借阅：" + hasBorrowed.ToString();
            }
        }

        private int GetReserveCount()
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

            object[] record = returnStringContent["record"];

            return record.Length;
        }
    }
}
