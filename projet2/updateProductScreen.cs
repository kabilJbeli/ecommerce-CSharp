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
    public partial class updateProductScreen : ecommerce.Form1
    {  public static String code;
        public updateProductScreen()
        {
            InitializeComponent();
        }


        private void updateProductScreen_Load(object sender, EventArgs e)
        {
            ProductDAO productDao = new ProductDAO();
            Product product = productDao.GetProduct(code);
            this.statusLabel.Text = "Update Product";
            this.statusStrip1.Refresh();
            this.productCode.Enabled = false;
            this.productCode.Text = code;
            this.productName.Text = product.Name;
            this.productBrand.Text = product.Brand;
            this.checkBtnState();
        }

        public void checkBtnState()
        {
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


        private void addproductbtn_Click(object sender, EventArgs e)
        {
            string code = this.productCode.Text;
            string productName = this.productName.Text;
            string productBrand = this.productBrand.Text;
            Product product = new Product(code, productName, productBrand);
            ProductDAO productDao = new ProductDAO();
           Boolean response=  productDao.updateProduct(product);
            if (response)
            {
                this.message.Text = "Product was successfully updated";
            }
            else
            {
                this.message.Text = "An Error Has Occured While Updating The Product";
            }

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
                this.errorLabel.Text = "Please write a valid product Name";
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
                this.errorLabel.Text = "Please write a Brand Name";
                this.errorLabel.ForeColor = Color.OrangeRed;
            }
            this.checkBtnState();

        }

        private void productCode_TextChanged(object sender, EventArgs e)
        {
            string text = this.productCode.Text;

            if (Validation.Validation.ValidateCode(text).Success)
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
    }
}
