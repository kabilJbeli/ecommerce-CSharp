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
           Boolean response = productDAO.setQuantityProduct(product);
            this.infoLabel.ForeColor = Color.OrangeRed;

            if (response)
            {
                this.infoLabel.Text = "Quantity Has been Adjusted with success in the selected product";
            }
            else
            {
                this.infoLabel.Text = "An Error Has Occured While Adjusting the quantity";

            }
        }

        private void supply_Load(object sender, EventArgs e)
        {

        }
    }
}
