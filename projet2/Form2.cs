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
            decimal price = decimal.Parse(this.price.Text);
            decimal tva = decimal.Parse(this.Tva.Text);

            this.productBrand.Text = "";
            this.productName.Text = "";
            this.productCode.Text = "";
            this.tvalabel.Text = "";
            this.price.Text = "";

            try
            {
                Product pd = new Product(code, brand, name);
                pd.Tva = tva;
                pd.PrixUnitaire = price;
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
                    throw new PRODUIT_EXISTE_EXCEPTION("A Product With the same ID Already Exist");
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
            this.errorLabel.Visible = true;
            this.message.Visible = false;

            if (!Validation.Validation.ValidateCode(this.productCode.Text).Success 
                || !Validation.Validation.ValidateNaming(this.productName.Text).Success
                || !Validation.Validation.ValidateNaming(this.productBrand.Text).Success
                || !Validation.Validation.ValidatePrice(this.price.Text).Success
                || !Validation.Validation.ValidateTva(this.Tva.Text).Success
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Tva_TextChanged(object sender, EventArgs e)
        {
            string text = this.Tva.Text;

            if (Validation.Validation.ValidateTva(text).Success)
            {
                this.Tva.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.Tva.ForeColor = Color.OrangeRed;

                this.errorLabel.Text = "Please write a valid TVA";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();

        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            string text = this.price.Text;

            if (Validation.Validation.ValidatePrice(text).Success)
            {
                this.price.ForeColor = Color.Green;
                this.errorLabel.Text = "";

            }
            else
            {
                this.price.ForeColor = Color.OrangeRed;

                this.errorLabel.Text = "Please write a valid Price";
                this.errorLabel.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();
        }
    }
}
