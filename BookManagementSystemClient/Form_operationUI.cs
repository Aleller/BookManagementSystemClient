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
        private Client client;

        public Form_operationUI(Client client)
        {
            InitializeComponent();

            this.client = client;
        }

        private void 借阅历史ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_borrowHistory child = new ChildWindow.Form_borrowHistory(this.client);
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
                ChildWindow.Form_orderInformation child = new ChildWindow.Form_orderInformation(this.client);
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

        private void 馆藏检索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChildWindow.Form_libraryQuery child = new ChildWindow.Form_libraryQuery(this.client);
                child.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
