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
            DataTable table = GetTable();
            DataGridView dt = new DataGridView();
            dt.Location = new Point(30, 26);
            dt.Visible = true;
            dt.DataSource = table;
            dt.AutoSize=true;
            dt.Refresh();
            Controls.Add(dt);
            this.statusLabel.Text = "Products List";
            this.statusStrip1.Refresh();
        }

        static DataTable GetTable()
        {
            // Step 2: here we create a DataTable.
            // ... We add 4 columns, each with a Type.
            DataTable table = new DataTable();
            table.Columns.Add("Code", typeof(string));
            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Name", typeof(string));

            // Step 3: here we add rows.
            ProductDAO productsDAO = new ProductDAO();
            List<Product> products = productsDAO.getProductsList();
            products.ForEach(item => {
                var row = table.NewRow();
                row["Code"] = item.Code;
                row["Brand"] = item.Brand;
                row["Name"] = item.Name;
                table.Rows.Add(row);
            });
          
            return table;
        }
    }
}
