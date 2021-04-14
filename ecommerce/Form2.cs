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
            Console.WriteLine("button clicked");
            string code = this.productCode.Text;
            string name = this.productName.Text;
            string brand = this.productBrand.Text;
            this.productBrand.Text = "";
            this.productName.Text = "";
            this.productCode.Text = "";
            this.message.Text = "Product Was Added With Success";
            Product pd = new Product(code, brand, name);
            ProductDAO dpd = new ProductDAO();
            dpd.setProduct(pd);
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
    }
}
