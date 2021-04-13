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
    public partial class productsList : ecommerce.Form1
    {
        public productsList()
        {
            InitializeComponent();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void productsList_Load(object sender, EventArgs e)
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.Location = new Point(0, 26);
            panel.Width = 1000;
            panel.Height = 1000;
            panel.ColumnCount = 3;
            panel.RowCount = 1;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
           // panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panel.Controls.Add(new Label() { Text = "Code" }, 1, 0);
            panel.Controls.Add(new Label() { Text = "Brand" }, 2, 0);
            panel.Controls.Add(new Label() { Text = "Name" }, 3, 0);

            ProductDAO productsDAO = new ProductDAO();
            List<Product> products= productsDAO.getProductsList();
            products.ForEach( item => {
                panel.RowCount = panel.RowCount + 1;
              panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                panel.Controls.Add(new Label() { Text = item.Code }, 1, panel.RowCount - 1);
                panel.Controls.Add(new Label() { Text = item.Brand }, 2, panel.RowCount - 1);
                panel.Controls.Add(new Label() { Text = item.Name }, 3, panel.RowCount - 1);

            });
            Controls.Add(panel);
        }
    }
}
