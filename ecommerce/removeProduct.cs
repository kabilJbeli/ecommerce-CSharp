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
    public partial class removeProduct : ecommerce.Form1
    {
        DataGridView dt;
        public removeProduct()
        {
            InitializeComponent();
        }

        private void removeProduct_Load(object sender, EventArgs e)
        {
            DataTable table = GetTable();
            dt = new DataGridView();
            dt.Location = new Point(30, 26);
            dt.Visible = true;

            dt.DataSource = table;

           
            dt.AutoSize = true;
            dt.Refresh();
            Controls.Add(dt);
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Action ";
            bcol.Text = "Delete";
            bcol.Name = "btnClickMe";
            bcol.UseColumnTextForButtonValue = true;
            dt.CellContentClick += btnClickMe_CellContentClick;
            dt.Columns.Add(bcol);
            dt.Refresh();

            this.statusLabel.Text = "Products List";
            this.statusStrip1.Refresh();
        }
        private void btnClickMe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ProductDAO productDAO = new ProductDAO();

                var rowIndex = e.RowIndex;

                //specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
                var id = dt.Rows[e.RowIndex].Cells[0].Value;
                productDAO.removeProduct(id.ToString());
                Console.WriteLine("Button Clicked");
                DataTable table = GetTable();
                dt.DataSource = table;
                dt.CellContentClick += btnClickMe_CellContentClick;
                this.dt.Refresh();
                Controls.Add(dt);

            }
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
       static void RemoveItem(Product item)
        {

        }
    }
}
