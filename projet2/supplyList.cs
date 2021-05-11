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
    public partial class supplyList : ecommerce.Form1
    {
        DataGridView dt;

        public supplyList()
        {
            InitializeComponent();
        }

        private void supplyList_Load(object sender, EventArgs e)
        {
            DataTable table = GetTable();
            dt = new DataGridView();
            dt.Location = new Point(30, 26);
            dt.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            dt.DataSource = table;
            dt.Width = 0;
            dt.Height = 0;
            dt.AutoSize = true;
            dt.Dock = DockStyle.Fill;
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt.BackgroundColor = SystemColors.ControlLightLight;
            dt.BorderStyle = BorderStyle.None;
            dt.Refresh();
            Controls.Add(dt);
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Action ";
            bcol.Text = "Supply";
            bcol.Name = "btnClickMe";
            bcol.UseColumnTextForButtonValue = true;
            dt.CellContentClick += btnClickMe_CellContentClick;
            dt.Columns.Add(bcol);
            dt.Refresh();
            this.statusLabel.Text = "Choose a product To Supply";
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

                supply Supply = new supply();
                supply.code = id.ToString();
                Supply.Show();
                this.Hide();
                DataTable table = GetTable();
                dt.DataSource = table;
                dt.CellContentClick += btnClickMe_CellContentClick;
                this.dt.Refresh();

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

    }
}
