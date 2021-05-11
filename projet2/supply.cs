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
    public partial class supply : ecommerce.Form1
    {
        public static string code;

        public supply()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void supplybtn_Click(object sender, EventArgs e)
        {   Product product = new Product();
            ProductDAO productDAO = new ProductDAO();
            product.Quantity = int.Parse(this.quantity.Text);
            product.Code = code;
            productDAO.setQuantityProduct(product);
        }

        private void supply_Load(object sender, EventArgs e)
        {

        }
    }
}
