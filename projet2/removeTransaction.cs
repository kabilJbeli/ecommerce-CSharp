﻿using ecommerce.ecommerceClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class removeTransaction : ecommerce.Form1
    {
        DataGridView dt;

        public removeTransaction()
        {
            InitializeComponent();
        }

        private void removeTransaction_Load(object sender, EventArgs e)
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
            bcol.Text = "Delete";
            bcol.Name = "btnClickMe";
            bcol.UseColumnTextForButtonValue = true;
            dt.CellContentClick += btnClickMe_CellContentClick;
            dt.Columns.Add(bcol);
            dt.Refresh();
            this.statusLabel.Text = "Remove Transaction";
            this.statusStrip1.Refresh();

        }


        private void btnClickMe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                TransactionDAO transactionDAO = new TransactionDAO();
                var rowIndex = e.RowIndex;
                //specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
                var id = dt.Rows[e.RowIndex].Cells[0].Value;
                transactionDAO.removeTransaction(id.ToString());
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
            table.Columns.Add("code", typeof(string));
            table.Columns.Add("Transaction Date", typeof(string));
            table.Columns.Add("Client", typeof(string));
            table.Columns.Add("Product", typeof(string));
            // Step 3: here we add rows.
            TransactionDAO transactionDAO = new TransactionDAO();
            try
            {
                List<Transaction> transactions = transactionDAO.getTransactionsList();
                if (transactions != null)
                {
                    transactions.ForEach(item =>
                    {
                        var row = table.NewRow();
                        row["code"] = item.Code;
                        row["Transaction Date"] = item.TransactionDate;
                        row["Client"] = item.Client.Name;
                        row["Product"] = item.Product.Name;
                        table.Rows.Add(row);
                    });
                }
                else
                {
                    throw new PAS_DE_TRANSACTION_EXCEPTION("The Transactions List Is Currently Empty");
                }
            } catch(PAS_DE_TRANSACTION_EXCEPTION exception) {
                string title = "Exception";
        string message = exception.Message;
        MessageBox.Show(message, title);

            Console.WriteLine(exception.Message);
            }
            return table;
        }
    }
}
