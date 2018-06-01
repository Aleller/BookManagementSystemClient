using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystemClient
{
    public partial class Form_register : Form
    {
        public Form_register()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (textBox_inputUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名");
                return;
            }

            if (textBox_inputPassword1.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }

            if (textBox_inputPassword2.Text.Trim() == "")
            {
                MessageBox.Show("请再次输入密码");
                return;
            }

            if (textBox_inputPassword1.Text.Trim() != textBox_inputPassword2.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致！");
                textBox_inputPassword1.Text = "";
                textBox_inputPassword2.Text = "";
                return;
            }

            //都没有问题了
            Client client = new Client();
            bool success = false;
            success = client.Register(textBox_inputUserName.Text.Trim(), textBox_inputPassword1.Text.Trim());
            if (success)
            {
                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
