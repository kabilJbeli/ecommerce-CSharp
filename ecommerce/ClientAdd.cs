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

        public void checkBtnState()
        {
            this.message.Visible = false;
            this.errorLabel.Visible = true;
            if (!Validation.Validation.ValidateTel(this.clientTel.Text).Success ||
                !Validation.Validation.ValidateCode(this.clientCode.Text).Success ||
                !Validation.Validation.ValidateEmail(this.clientEmail.Text).Success ||
                !Validation.Validation.ValidateNaming(this.clientName.Text).Success ||
                !Validation.Validation.ValidateNaming(this.clientLastName.Text).Success ||
                !Validation.Validation.ValidateNaming(this.clientAdress.Text).Success)
            {

                this.addClient.Enabled = false;
            }
            else
            {
                this.addClient.Enabled = true;

            }

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
            this.checkBtnState();

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
                this.message.Visible = true;
                this.errorLabel.Visible = false;
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
                string title = "Exception";
                string message = exception.Message;
                MessageBox.Show(message, title);                
                Console.WriteLine(exception.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientName_TextChanged(object sender, EventArgs e)
        {
            string text = this.clientName.Text;

            if (Validation.Validation.ValidateNaming(text).Success)
            {
                this.clientName.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.clientName.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Please write a valid client name";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();

        }

        private void clientTel_KeyDown(object sender, KeyEventArgs e)
        {
         

        }

       


        private void clientEmail_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void clientEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
      

        }

        private void clientCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

      

        private void clientCode_TextChanged(object sender, EventArgs e)
        {
            string code = this.clientCode.Text;

            if (Validation.Validation.ValidateCode(code).Success)
            {
                this.clientCode.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.clientCode.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Please write a valide code number";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();
        }

        private void clientLastName_TextChanged_1(object sender, EventArgs e)
        {
            string text = this.clientLastName.Text;

            if (Validation.Validation.ValidateNaming(text).Success)
            {
                this.clientLastName.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.clientLastName.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Last Name should contain only string values";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();
        }

        private void clientEmail_TextChanged(object sender, EventArgs e)
        {
            string text = this.clientEmail.Text;

            if (Validation.Validation.ValidateEmail(text).Success)
            {
                this.clientEmail.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.clientEmail.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Please write a valid email address";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();
        }

        private void clientTel_TextChanged(object sender, EventArgs e)
        {
            string code = this.clientTel.Text;

            if (Validation.Validation.ValidateTel(code).Success)
            {
                this.clientTel.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.clientTel.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Please write a valid phone number";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();

        }

        private void clientAdress_TextChanged_1(object sender, EventArgs e)
        {
            string text = this.clientAdress.Text;

            if (Validation.Validation.ValidateNaming(text).Success)
            {
                this.clientAdress.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.clientAdress.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Please write a valid address";
                this.errorLabel.ForeColor = Color.OrangeRed;
            }
            this.checkBtnState();
        }
    }
}
