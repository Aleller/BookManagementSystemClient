﻿using System;
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

            comboBox_userGroup.SelectedIndex = 0;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                Client c = new Client();
                string userName = textBox_userName.Text.Trim();
                string password = textBox_password.Text.Trim();

                int userGroup_int = comboBox_userGroup.SelectedIndex;
                string userGroup;
                switch (userGroup_int)
                {
                    case 0:
                        userGroup = "reader";
                        break;
                    case 1:
                        userGroup = "admin";
                        break;
                    default:
                        userGroup = "error";
                        break;
                }

                Dictionary<string, string> result = c.Login(userName, password, userGroup);

                if (result["status"] == "successful")
                {
                    switch (result["userGroup"])
                    {
                        case "reader":
                            new System.Threading.Thread(() =>
                            {
                                Application.Run(new Form_operationUI(c));
                            }).Start();
                            this.Close();
                            break;
                        case "admin":
                            new System.Threading.Thread(() =>
                            {
                                Application.Run(new Form_SystemAdministratorUI(c));
                            }).Start();
                            this.Close();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }catch(Exception exception)
            {
                MessageBox.Show("网络异常，" + exception.ToString());
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(() =>
            {
                Application.Run(new Form_register());
            }).Start();
        }
    }
}
