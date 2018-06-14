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
    }
}
