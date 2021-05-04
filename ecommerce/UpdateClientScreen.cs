using System;
using ecommerce.ecommerceClasses;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class UpdateClientScreen : ecommerce.Form1
    {
        public static string code;
        public UpdateClientScreen()
        {
            InitializeComponent();
        }

        private void UpdateClientScreen_Load(object sender, EventArgs e)
        {
            ClientDAO clientDao = new ClientDAO();
            Client client = clientDao.GetClient(code);
            this.statusLabel.Text = "Update Client";
            this.statusStrip1.Refresh();
            this.clientCode.Enabled = false;
            this.clientCode.Text = code;
            this.clientEmail.Text = client.Email;
            this.clientName.Text = client.Name;
            this.clientLastName.Text = client.LastName;
            this.clientTel.Text = client.Tel.ToString();
            this.clientAdress.Text = client.Adress;
        }

        private void addClient_Click_1(object sender, EventArgs e)
        {
            string code = this.clientCode.Text;
            string clientName = this.clientName.Text;
            string clientLastName = this.clientLastName.Text;
            string email = this.clientEmail.Text;
            int tel = int.Parse(this.clientTel.Text);
            string adress = this.clientAdress.Text;
            Client client = new Client(code, clientName, clientLastName, email, tel, adress);
            ClientDAO clientDAO = new ClientDAO();
            Boolean response = clientDAO.updateClient(client);

            if (response)
            {
                this.message.Text = "Client Was Updated Successfully";
            }
            else
            {
                this.message.Text = "An Error Has Occured While Updating The Client";
            }
        }

        private void clientEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string email = this.clientEmail.Text;
            if (Validation.Validation.ValidateEmail(email).Success)
            {
                this.clientEmail.ForeColor = Color.Green;
            }
            else
            {
                this.clientEmail.ForeColor = Color.OrangeRed;

            }
        }
    }
}
