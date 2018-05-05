using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BookManagementSystemClient.Util;

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
            textBox_userName.Text = "2015210842";
            textBox_password.Text = "123456";

            HttpHandler handler = new HttpHandler();
            string url = "http://45.77.191.48:9090/login/submit";
            string userName = textBox_userName.Text.Trim();
            string password = textBox_password.Text.Trim();
            string data = "studentID=" + userName + "&" + "password=" + password;
            //string data = "{ \"studentID\" : \"" + userName + "\", \"password\" : \"" + password + "\" }";
            Console.WriteLine(data);
            handler.HttpPost(url, data);
        }
    }
}
