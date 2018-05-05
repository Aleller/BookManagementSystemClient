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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                Client c = new Client();
                string userName = textBox_userName.Text.Trim();
                string password = textBox_password.Text.Trim();

                bool success = c.Login(userName, password);

                if (success)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }catch(Exception exception)
            {
                MessageBox.Show("网络异常");
            }
        }
    }
}
