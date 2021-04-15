using System;
using ecommerce.ecommerceClasses;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class clientList : ecommerce.Form1
    {
        public clientList()
        {
            InitializeComponent();
        }

        private void clientList_Load(object sender, EventArgs e)
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
            this.statusLabel.Text = "Clients List";
            this.statusStrip1.Refresh();
        }


        static DataTable GetTable()
        {
            // Step 2: here we create a DataTable.
            // ... We add 4 columns, each with a Type.
            DataTable table = new DataTable();
           table.Columns.Add("code", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Email", typeof(string));
          //  table.Columns.Add("Tel", typeof(int));
            table.Columns.Add("Adress", typeof(string));

            // Step 3: here we add rows.
            ClientDAO clientDAO = new ClientDAO();
            List<Client> clients = clientDAO.getClientsList();
            clients.ForEach( item => {
                var row = table.NewRow();
                row["code"] = item.Code;
               row["Name"] = item.Name;
               row["LastName"] = item.LastName;
               row["Email"] = item.Email;
                row["Adress"] = item.Adress;

                table.Rows.Add(row);
            });

            return table;
        }

    }
}
