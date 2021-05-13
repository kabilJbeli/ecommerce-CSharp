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
    public partial class Form2 : ecommerce.Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addproduct(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            string code = this.productCode.Text;
            string name = this.productName.Text;
            string brand = this.productBrand.Text;
                Console.WriteLine("button clicked");
                this.productBrand.Text = "";
                this.productName.Text = "";
                this.productCode.Text = "";
            try
            {
                Product pd = new Product(code, brand, name);
                Boolean response = productDAO.setProduct(pd);
                this.message.Visible = true;
                this.errorLabel.Visible = false;
                if (response)
                {
                    this.message.Text = "Product Was Added With Success";
                }
                else
                {
                    this.message.Text = "An Error Has Occured While Adding the Product";
                }
                Point p = new Point();
                p.X = 0;
                this.message.PointToScreen(p);
            }
            catch (PRODUIT_EXISTE_EXCEPTION exception) {

                string title = "Exception";
                string message = exception.Message;
                MessageBox.Show(message, title);
                Console.WriteLine(exception.Message);
            }


        }

        public void checkBtnState()
        {
            this.message.Visible = false;
            this.errorLabel.Visible = true;
            if (!Validation.Validation.ValidateCode(this.productCode.Text).Success 
                || !Validation.Validation.ValidateNaming(this.productName.Text).Success
                || !Validation.Validation.ValidateNaming(this.productBrand.Text).Success
                )
            {

                this.addproductbtn.Enabled = false;
            }
            else
            {
                this.addproductbtn.Enabled = true;

            }

        }
        private void productCode_TextChanged(object sender, EventArgs e)
        {

            string code = this.productCode.Text;

            if (Validation.Validation.ValidateCode(code).Success)
            {
                this.productCode.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.productCode.ForeColor = Color.OrangeRed;
                this.errorLabel.Text = "Please write a valid code";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.statusLabel.Text = "Add Product";
            this.statusStrip1.Refresh();
            this.checkBtnState();

        }

        private void productCode_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void productName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {
            string text = this.productName.Text;

            if (Validation.Validation.ValidateNaming(text).Success)
            {
                this.productName.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.productName.ForeColor = Color.OrangeRed;

                this.errorLabel.Text = "Please write a valid product name";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();

        }

        private void productBrand_TextChanged(object sender, EventArgs e)
        {
            string text = this.productBrand.Text;

            if (Validation.Validation.ValidateNaming(text).Success)
            {
                this.productBrand.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.productBrand.ForeColor = Color.OrangeRed;

                this.errorLabel.Text = "Please write a valid product brand";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();

        }
    }
}
