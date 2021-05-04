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
    }
}
