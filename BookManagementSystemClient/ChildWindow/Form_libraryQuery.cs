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
    public partial class Form_libraryQuery : Form
    {
        private Client client;

        public Form_libraryQuery(Client client)
        {
            InitializeComponent();

            this.client = client;

            this.comboBox_queryType.SelectedIndex = 0;
            this.comboBox_sortordProperty.SelectedIndex = 0;
            this.comboBox_sortordUpDown.SelectedIndex = 0;
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            this.RetrieveBook();
        }

        private void RetrieveBook()
        {
            if (textBox_inputQuery.Text.Trim() == "")
            {
                return;
            }

            string value = textBox_inputQuery.Text.Trim();
            string name_ch = (string)comboBox_queryType.SelectedItem;
            string name;
            switch (name_ch)
            {
                case "任意词":
                    name = "any";
                    break;
                case "唯一标识符":
                    name = "MarcNo";
                    break;
                case "题名":
                    name = "Title";
                    break;
                case "作者":
                    name = "Author";
                    break;
                case "出版社":
                    name = "Publisher";
                    break;
                case "ISBN":
                    name = "ISBN";
                    break;
                case "价格":
                    name = "Price";
                    break;
                case "馆藏地":
                    name = "Carrier";
                    break;
                case "科目":
                    name = "Subject";
                    break;
                case "中图法分类号":
                    name = "CLS";
                    break;
                default:
                    name = "error";
                    break;
            }

            //准备发送数据
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");

            string page = 1.ToString();

            string sendString = "";

            string url = "http://45.77.191.48:7575/book/information/" + name + "/" + value + "/" + page;

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpGet(url, sendString);

            //受到响应，显示数据
            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic returnStringContent = js.Deserialize<dynamic>(returnString);

            string status = returnStringContent["status"];
            object[] result = returnStringContent["result"];

            if(status == "successful")
            {
                for(int i=0; i<result.Length; i++)
                {
                    dynamic dic = result[i] as Dictionary<string, object>;
                    ListViewItem item = new ListViewItem();
                    item.Text = "预约";
                    item.SubItems.Add(dic["marcNo"]);
                    item.SubItems.Add(dic["title"]);
                    item.SubItems.Add(dic["author"]);
                    item.SubItems.Add(dic["publisher"]);
                    item.SubItems.Add(dic["ISBN"]);
                    item.SubItems.Add(dic["price"]);
                    item.SubItems.Add(dic["carrier"]);
                    item.SubItems.Add(dic["subject"]);
                    item.SubItems.Add(dic["cls"]);

                    listView_borrowedBooks.Items.Add(item);
                }
            }
        }

        private void listView_borrowedBooks_ItemActivate(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection c = listView_borrowedBooks.SelectedIndices;
            string MarcNo = listView_borrowedBooks.Items[c[0]].SubItems[1].Text;
            string url = "http://45.77.191.48:7575/book/collection/" + MarcNo;

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpGet(url, "");

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic returnStringContent = js.Deserialize<dynamic>(returnString);
            string status = returnStringContent["status"];
            
            if(status == "successful")
            {
                try
                {
                    ChildWindow.Form_reserveBooks child = new ChildWindow.Form_reserveBooks(this.client, returnString);
                    child.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("获取馆藏信息失败");
            }
        }
    }
}
