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
    public partial class Form_SystemAdministratorUI : Form
    {
        private Client client;

        public Form_SystemAdministratorUI(Client client)
        {
            InitializeComponent();

            this.client = client;
        }

        private void button_addBook_Click(object sender, EventArgs e)
        {
            try
            {
                SystemAdministratorChildWindow.Form_systemAdministratorAddBook child = new SystemAdministratorChildWindow.Form_systemAdministratorAddBook();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_deleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                SystemAdministratorChildWindow.Form_systemAdministratorDeleteBook child = new SystemAdministratorChildWindow.Form_systemAdministratorDeleteBook();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_updateBook_Click(object sender, EventArgs e)
        {
            try
            {
                SystemAdministratorChildWindow.Form_systemAdministratorUpdateBook child = new SystemAdministratorChildWindow.Form_systemAdministratorUpdateBook();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            string oldKey = textBox_oldKey.Text.Trim();
            string newKey1 = textBox_newKey1.Text.Trim();
            string newKey2 = textBox_newKey2.Text.Trim();

            if (oldKey == "")
            {
                MessageBox.Show("请输入原验证码");
                return;
            }

            if (newKey1 == "")
            {
                MessageBox.Show("请输入新验证码");
                return;
            }

            if (newKey2 == "")
            {
                MessageBox.Show("请再次输入新验证码");
                return;
            }

            if (newKey1 != newKey2)
            {
                MessageBox.Show("两次输入的新验证码不一致！");
                textBox_newKey1.Text = "";
                textBox_newKey2.Text = "";
                return;
            }

            //都没有问题了
            bool successful = this.SetKey(oldKey, newKey1);
            if (successful)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }

            textBox_newKey1.Text = "";
            textBox_newKey2.Text = "";
            textBox_oldKey.Text = "";
        }

        private bool SetKey(string oldKey, string newKey)
        {
            string encryptedOldKey = Cipher.AutoEncrypt(oldKey);
            encryptedOldKey = encryptedOldKey.Replace("+", "%2B");
            string encryptedNewKey = Cipher.AutoEncrypt(newKey);
            encryptedNewKey = encryptedNewKey.Replace("+", "%2B");

            HttpHandler httpHandler = new HttpHandler();
            string url = "http://45.77.191.48:7575/admin/key/set";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("old", encryptedOldKey);
            dic.Add("new", encryptedNewKey);

            string returnString = httpHandler.HttpPost(url, dic);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic returnStringContent = serializer.Deserialize<dynamic>(returnString);
            string status = returnStringContent["status"];

            if(status == "successful")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_release_Click(object sender, EventArgs e)
        {
            string message = textBox_announcement.Text;

            bool successful = this.MakeAnnouncement(message);

            if(successful)
            {
                MessageBox.Show("发布成功");
                textBox_announcement.Text = "";
            }
            else
            {
                MessageBox.Show("发布失败");
            }
        }

        private bool MakeAnnouncement(string message)
        {
            message = message.Replace("+", "%2B");
            string url = "http://45.77.191.48:7575/admin/broadcast/set";

            HttpHandler httpHandler = new HttpHandler();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("msg", message);
            string returnString = httpHandler.HttpPost(url, dictionary);

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

        private void button_retrieveBook_Click(object sender, EventArgs e)
        {

        }
    }
}
