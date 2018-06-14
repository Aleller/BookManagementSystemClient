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
    public partial class Form_systemAdministratorAddCollection : Form
    {
        public Form_systemAdministratorAddCollection()
        {
            InitializeComponent();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            bool successful = this.AddCollection();
            if (successful)
            {
                MessageBox.Show("添加成功");
                textBox_barcode.Text = "";
                textBox_status.Text = "";
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
        
        private bool AddCollection()
        {
            string marcNo = textBox_marcNo.Text.Trim();
            string callNumber = textBox_callNumber.Text.Trim();
            string barcode = textBox_barcode.Text.Trim();
            string volume = textBox_volume.Text.Trim();
            string holding = textBox_holding.Text.Trim();
            string status = textBox_status.Text.Trim();
            string returning = textBox_returning.Text.Trim();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("marcNo", marcNo);
            dic.Add("callNumber", callNumber);
            dic.Add("barcode", barcode);
            dic.Add("volume", volume);
            dic.Add("holding", holding);
            dic.Add("status", status);
            dic.Add("returning", returning);

            string url = "http://45.77.191.48:7575/admin/collection/insert";

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpPost(url, dic);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic content = js.Deserialize<dynamic>(returnString);

            string returnStatus = content["status"];
            if(returnStatus == "successful")
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
