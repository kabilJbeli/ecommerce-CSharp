using ecommerce.ecommerceClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class ClientAdd : ecommerce.Form1
    {
        public ClientAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClientAdd_Load(object sender, EventArgs e)
        {
            this.statusLabel.Text = "Add Client";        
            this.statusStrip1.Refresh();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addClient_Click(object sender, EventArgs e)
        {
            string code = this.clientCode.Text;
            string clientName = this.clientName.Text;
            string clientLastName = this.clientLastName.Text;
            string email = this.clientEmail.Text;
            int tel = 5;//int.Parse(this.clientTel.Text);
            string adress = this.clientAdress.Text;
            Client client = new Client(code,clientName,clientLastName,email,tel,adress);
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.setClient(client);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
