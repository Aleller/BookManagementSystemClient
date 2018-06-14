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
    public partial class Form_systemAdministratorAddHolding : Form
    {
        public Form_systemAdministratorAddHolding()
        {
            InitializeComponent();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            bool successful = this.AddHolding();
            if (successful)
            {
                MessageBox.Show("添加成功");
                textBox_barcode.Text = "";
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
        
        private bool AddHolding()
        {
            string marcNo = textBox_marcNo.Text.Trim();
            string callNumber = textBox_callNumber.Text.Trim();
            string barcode = textBox_barcode.Text.Trim();

            HttpHandler httpHandler = new HttpHandler();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("marcNo", marcNo);
            dic.Add("callNumber", callNumber);
            dic.Add("barcode", barcode);
            string url = "http://45.77.191.48:7575/admin/collection";

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
