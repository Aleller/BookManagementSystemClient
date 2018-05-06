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
    public partial class Form_operationUI : Form
    {
        public Form_operationUI()
        {
            InitializeComponent();
        }

        private void 证件信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_personalInformation child = new ChildWindow.Form_personalInformation();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 借阅历史ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_borrowHistory child = new ChildWindow.Form_borrowHistory();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 预约信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_orderInformation child = new ChildWindow.Form_orderInformation();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}