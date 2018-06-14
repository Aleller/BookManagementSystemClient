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
    public partial class Form_systemAdministratorAddBook : Form
    {
        public Form_systemAdministratorAddBook()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            bool successful = this.AddBook();

            if (successful)
            {
                MessageBox.Show("添加成功");
                textBox_MarcNo.Text = "";
                textBox_Title.Text = "";
                textBox_Author.Text = "";
                textBox_Publisher.Text = "";
                textBox_ISBN.Text = "";
                textBox_Price.Text = "";
                textBox_Carrier.Text = "";
                textBox_Subject.Text = "";
                textBox_CLS.Text = "";
            }

        }

        

        private bool AddBook()
        {
            string url = "http://45.77.191.48:7575/admin/book/insert";

            string MarcNo = textBox_MarcNo.Text.Trim();
            string Title = textBox_Title.Text.Trim();
            string Author = textBox_Author.Text.Trim();
            string Publisher = textBox_Publisher.Text.Trim();
            string ISBN = textBox_ISBN.Text.Trim();
            string Price = textBox_Price.Text.Trim();
            string Carrier = textBox_Carrier.Text.Trim();
            string Subject = textBox_Subject.Text.Trim();
            string CLS = textBox_CLS.Text.Trim();
            

            HttpHandler httpHandler = new HttpHandler();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("marcNo", MarcNo);
            dic.Add("title", Title);
            dic.Add("author", Author);
            dic.Add("publisher", Publisher);
            dic.Add("ISBN", ISBN);
            dic.Add("price", Price);
            dic.Add("carrier", Carrier);
            dic.Add("subject", Subject);
            dic.Add("CLS", CLS);

            string returnString = httpHandler.HttpPost(url, dic);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic returnStringContent = serializer.Deserialize<dynamic>(returnString);

            string status = returnStringContent["status"];

            if(status == "successful")
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SystemAdministratorChildWindow.Form_systemAdministratorAddHolding child = new SystemAdministratorChildWindow.Form_systemAdministratorAddHolding();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
