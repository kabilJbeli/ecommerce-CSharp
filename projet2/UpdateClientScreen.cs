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
            this.checkBtnState();

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

        }

        public void checkBtnState()
        {

            if(!Validation.Validation.ValidateTel(this.clientTel.Text).Success
                || !Validation.Validation.ValidateCode(this.clientCode.Text).Success
                || !Validation.Validation.ValidateEmail(this.clientEmail.Text).Success
                || !Validation.Validation.ValidateNaming(this.clientName.Text).Success
                || !Validation.Validation.ValidateNaming(this.clientLastName.Text).Success
                || !Validation.Validation.ValidateNaming(this.clientAdress.Text).Success
                )
            {

                this.addClient.Enabled = false;
            }
            else
            {
                this.addClient.Enabled = true;

            }

        }
        private void clientTel_KeyPress(object sender, KeyPressEventArgs e)
        {
     

        }


        private void clientLastName_TextChanged(object sender, EventArgs e)
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

                this.errorLabel.Text = "Please write a valid Client last Name";
                this.errorLabel.ForeColor = Color.OrangeRed;
            }
            this.checkBtnState();

        }

        private void clientAdress_TextChanged(object sender, EventArgs e)
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
                this.errorLabel.Text = "Please write a valid Adress";
                this.errorLabel.ForeColor = Color.OrangeRed;
            }
            this.checkBtnState();

        }

        private void clientName_TextAlignChanged(object sender, EventArgs e)
        {
           

        }

        private void clientEmail_TextChanged(object sender, EventArgs e)
        {
            string email = this.clientEmail.Text;
            if (Validation.Validation.ValidateEmail(email).Success)
            {
                this.clientEmail.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.clientEmail.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Please write a valid Email Adress";
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
                this.errorLabel.Text = "Please write a valid Client Name";
                this.errorLabel.ForeColor = Color.OrangeRed;
            }
            this.checkBtnState();
        }

        private void clientCode_TextChanged(object sender, EventArgs e)
        {
            string text = this.clientCode.Text;

            if (Validation.Validation.ValidateCode(text).Success)
            {
                this.clientCode.ForeColor = Color.Green;

                this.errorLabel.Text = "";

            }
            else
            {
                this.clientCode.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Please write a valid code";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();
        }
    }
}
