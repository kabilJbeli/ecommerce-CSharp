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
    public partial class transactionList : ecommerce.Form1
    {
        public transactionList()
        {
            InitializeComponent();
        }

        private void transactionList_Load(object sender, EventArgs e)
        {
            DataTable table = GetTable();
            DataGridView dt = new DataGridView();
            // dt.Location = new Point(50, 56);
            dt.Visible = true;
            dt.DataSource = table;
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
            this.statusLabel.Text = "Transactions List";
            this.statusStrip1.Refresh();
        }

 


        static DataTable GetTable()
        {
            // Step 2: here we create a DataTable.
            // ... We add 4 columns, each with a Type.
            DataTable table = new DataTable();
            table.Columns.Add("code", typeof(string));
            table.Columns.Add("Client Name", typeof(string));
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Transaction Date Time", typeof(string));
            //  table.Columns.Add("Tel", typeof(int));
            table.Columns.Add("Adress", typeof(string));

            // Step 3: here we add rows.
            TransactionDAO transactiontDAO = new TransactionDAO();
            List<Transaction> transactions = transactiontDAO.getTransactionsList();
            transactions.ForEach(item => {
                var row = table.NewRow();
                row["code"] = item.Code;
                row["Client Name"] = item.Client;
                row["Product Name"] = item.Product;
                row["Transaction Date"] = item.TransactionDate;

                table.Rows.Add(row);
            });

            return table;
        }
    }
}
