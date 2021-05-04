using ecommerce.ecommerceClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ecommerce.Validation;
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
            try
            {
                string code = this.clientCode.Text;
                string clientName = this.clientName.Text;
                string clientLastName = this.clientLastName.Text;
                string email = this.clientEmail.Text;
                int tel = int.Parse(this.clientTel.Text);
                string adress = this.clientAdress.Text;
                Client client = new Client(code, clientName, clientLastName, email, tel, adress);
                ClientDAO clientDAO = new ClientDAO();
                Boolean response = clientDAO.setClient(client);

                if (response)
                {
                    this.message.Text = "Client Was Added With Success";
                }
                else
                {
                    this.message.Text = "An Error Has Occured While Adding The Client";

                }
            }catch(ClIENT_EXISTE_EXCEPTION exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientTel_KeyDown(object sender, KeyEventArgs e)
        {
       

        }

        private void clientEmail_KeyDown(object sender, KeyEventArgs e)
        {
   
        }

        private void clientEmail_KeyPress(object sender, KeyPressEventArgs e)
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

        private void clientCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            string code = this.clientCode.Text;

            if (Validation.Validation.ValidateCode(code).Success)
            {
                this.clientCode.ForeColor = Color.Green;
            }
            else
            {
                this.clientCode.ForeColor = Color.OrangeRed;

            }
        }
    }
}
