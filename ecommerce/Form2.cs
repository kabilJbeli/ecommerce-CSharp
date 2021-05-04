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

                Console.WriteLine(exception.Message);
            }


        }

        private void productCode_TextChanged(object sender, EventArgs e)
        {
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
        }

        private void productCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            string code = this.productCode.Text;

            if (Validation.Validation.ValidateCode(code).Success)
            {
                this.productCode.ForeColor = Color.Green;
            }
            else
            {
                this.productCode.ForeColor = Color.OrangeRed;

            }
        }
    }
}
