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

namespace BookManagementSystemClient.SystemAdministratorChildWindow
{
    public partial class Form_systemAdministratorUpdateBook : Form
    {
        public Form_systemAdministratorUpdateBook()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string marcNo = textBox_searchMarcNo.Text.Trim();
            this.searchMarcNo(marcNo);
        }

        private void searchMarcNo(string marcNo)
        {
            string url = "http://45.77.191.48:7575/book/information/MarcNo/" + marcNo + "/1";

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpGet(url, "");

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic content = js.Deserialize<dynamic>(returnString);

            string status = content["status"];
            object[] result = content["result"];

            if (result.Length > 1)
            {
                MessageBox.Show("记录多于一条，无法确定！");
                return;
            }

            if (status == "successful")
            {
                for (int i = 0; i < result.Length; i++)
                {
                    dynamic dic = result[i] as Dictionary<string, object>;
                    textBox_MarcNo.Text = dic["marcNo"];
                    textBox_Title.Text = dic["title"];
                    textBox_Author.Text = dic["author"];
                    textBox_Publisher.Text = dic["publisher"];
                    textBox_ISBN.Text = dic["ISBN"];
                    textBox_Price.Text = dic["price"];
                    textBox_Carrier.Text = dic["carrier"];
                    textBox_Subject.Text = dic["subject"];
                    textBox_CLS.Text = dic["cls"];
                }
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            bool successful = this.UpdateBook();
            if (successful)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private bool UpdateBook()
        {
            string url = "http://45.77.191.48:7575/admin/book/update";

            string marcNo = textBox_MarcNo.Text.Trim();
            string title = textBox_Title.Text.Trim();
            string author = textBox_Author.Text.Trim();
            string publisher = textBox_Publisher.Text.Trim();
            string ISBN = textBox_ISBN.Text.Trim();
            string price = textBox_Price.Text.Trim();
            string carrier = textBox_Carrier.Text.Trim();
            string subject = textBox_Subject.Text.Trim();
            string CLS = textBox_CLS.Text.Trim();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            HttpHandler httpHandler = new HttpHandler();
            dic.Add("marcNo", marcNo);
            dic.Add("title", title);
            dic.Add("author", author);
            dic.Add("publisher", publisher);
            dic.Add("ISBN", ISBN);
            dic.Add("price", price);
            dic.Add("carrier", carrier);
            dic.Add("subject", subject);
            dic.Add("CLS", CLS);

            string returnString = httpHandler.HttpPost(url, dic);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic returnStringContent = serializer.Deserialize<dynamic>(returnString);

            string status = returnStringContent["status"];

            if (status == "successful")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
