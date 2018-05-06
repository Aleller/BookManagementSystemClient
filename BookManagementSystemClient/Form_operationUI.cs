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

        private void 我的书架ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_myBookshelf child = new ChildWindow.Form_myBookshelf();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 书刊遗失ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_booksLost child = new ChildWindow.Form_booksLost();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 读者挂失ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_reportLoss child = new ChildWindow.Form_reportLoss();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 账目清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_bill child = new ChildWindow.Form_bill();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 违章缴款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_pay child = new ChildWindow.Form_pay();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 我的书评ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_review child = new ChildWindow.Form_review();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 检索历史ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_queryHistory child = new ChildWindow.Form_queryHistory();
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
