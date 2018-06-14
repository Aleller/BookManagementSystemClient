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
    public partial class Form_systemAdministratorDeleteBook : Form
    {
        public Form_systemAdministratorDeleteBook()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            bool successful = this.DeleteBook();
            if (successful)
            {
                MessageBox.Show("删除成功");
            }else
            {
                MessageBox.Show("删除失败");
            }
        }

        private bool DeleteBook()
        {
            string marcNo = textBox_MarcNo.Text.Trim();
            string url = "http://45.77.191.48:7575/admin/book/delete";

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("marcNo", marcNo);

            HttpHandler httpHandler = new HttpHandler();

            string returnString = httpHandler.HttpPost(url, dic);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic content = js.Deserialize<dynamic>(returnString);

            string status = content["status"];
            if(status == "successful")
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
