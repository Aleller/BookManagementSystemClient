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
    public partial class Form_systemAdminitratorUpdateCollection : Form
    {
        public Form_systemAdminitratorUpdateCollection()
        {
            InitializeComponent();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            bool successful = this.UpdateCollection();
            if (successful)
            {
                MessageBox.Show("修改成功");
            }else
            {
                MessageBox.Show("修改失败");
            }
        }

        private bool UpdateCollection()
        {
            string barcode = textBox_barcode.Text.Trim();
            string volume = textBox_volume.Text.Trim();
            string holding = textBox_holding.Text.Trim();
            string status = "";
            string returning = textBox_returning.Text.Trim();

            switch (comboBox_status.SelectedIndex)
            {
                case 0:
                    status = "保留本";
                    break;
                case 1:
                    status = "可借";
                    break;
                default:
                    status = "error";
                    break;
            }

            string url = "http://45.77.191.48:7575/admin/collection/update";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("barcode", barcode);
            dic.Add("volume", volume);
            dic.Add("holding", holding);
            dic.Add("status", status);
            dic.Add("returning", returning);

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpPost(url, dic);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic content = js.Deserialize<dynamic>(returnString);

            string returnStatus = content["status"];
            if (returnStatus == "successful")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_confirmDelete_Click(object sender, EventArgs e)
        {
            bool successful = this.DeleteCollection();
            if (successful)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private bool DeleteCollection()
        {
            string barcode = textBox_barcodeDelete.Text.Trim();
            string callNumber = textBox_callNumberDelete.Text.Trim();

            string url = "http://45.77.191.48:7575/admin/collection/delete";

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("barcode", barcode);
            dic.Add("callNumber", callNumber);

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpPost(url, dic);

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic content = js.Deserialize<dynamic>(returnString);

            string returnStatus = content["status"];
            if (returnStatus == "successful")
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
