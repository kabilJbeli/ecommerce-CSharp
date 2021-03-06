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
            dt.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            dt.DataSource = table;
            dt.Width = 0;
            dt.Height = 0;
            dt.AutoSize = true;
            dt.Dock= DockStyle.Fill;
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt.BackgroundColor = SystemColors.ControlLightLight;
            dt.BorderStyle = BorderStyle.None;
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
            this.statusLabel.Text = "Remove Product";
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
            // Step 3: here we add rows.$
            try
            {
                ProductDAO productsDAO = new ProductDAO();
                List<Product> products = productsDAO.getProductsList();
                if (products != null)
                {
                    products.ForEach(item =>
                    {
                        var row = table.NewRow();
                        row["Code"] = item.Code;
                        row["Brand"] = item.Brand;
                        row["Name"] = item.Name;
                        table.Rows.Add(row);
                    });
                }
                else
                {
                    throw new PAS_DE_PRODUITS_EXCEPTION("The products list is empty");
                }
            }catch(PAS_DE_PRODUITS_EXCEPTION exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK);

            }
            return table;
        }
       static void RemoveItem(Product item)
        {

        }
    }
}
