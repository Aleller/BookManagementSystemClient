using BookManagementSystemClient.Util;
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
    public partial class Form_orderInformation : Form
    {
        Client client;

        public Form_orderInformation(Client client)
        {
            InitializeComponent();

            this.client = client;

            this.GetReserveInformation();
        }

        private void button_reserve_Click(object sender, EventArgs e)
        {
            this.ReserveBook();
        }

        private void ReserveBook()
        {
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");
            string CallNumber = textBox_CallNumber.Text.Trim();

            string url = "http://45.77.191.48:7575/reserve/apply";

            HttpHandler httpHandler = new HttpHandler();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", id);
            dic.Add("token", token);
            dic.Add("callNumber", CallNumber);
            string returnString = httpHandler.HttpPost(url, dic);
        }

        private void GetReserveInformation()
        {
            string id = client.GetUserName();
            string token = client.GetToken();
            token = token.Replace("+", "%2B");
            string url = "http://45.77.191.48:7575/reserve/history";
            string sendString = "id=" + id + "&token=" + token;

            HttpHandler httpHandler = new HttpHandler();
            string returnString = httpHandler.HttpGet(url, sendString);
        }
    }
}
