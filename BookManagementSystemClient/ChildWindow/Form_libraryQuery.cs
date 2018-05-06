using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystemClient.ChildWindow
{
    public partial class Form_libraryQuery : Form
    {
        public Form_libraryQuery()
        {
            InitializeComponent();
            this.comboBox_queryType.SelectedIndex = 0;
            this.comboBox_sortordProperty.SelectedIndex = 0;
            this.comboBox_sortordUpDown.SelectedIndex = 0;
        }
    }
}
