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
    public partial class updateClient : ecommerce.Form1
    {
        DataGridView dt;

        public updateClient()
        {
            InitializeComponent();
        }

        private void updateClient_Load(object sender, EventArgs e)
        {
            this.statusLabel.Text = "Update Client List";
            this.statusStrip1.Refresh();
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
            bcol.Text = "Update";
            bcol.Name = "btnClickMe";
            bcol.UseColumnTextForButtonValue = true;
            dt.CellContentClick += btnClickMe_CellContentClick;
            dt.Columns.Add(bcol);
            dt.Refresh();
   
        }


        private void btnClickMe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                ClientDAO clientDAO = new ClientDAO();
                var rowIndex = e.RowIndex;
                //specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
                var id = dt.Rows[e.RowIndex].Cells[0].Value;

                UpdateClientScreen updateClientScreen = new UpdateClientScreen();
                UpdateClientScreen.code = id.ToString();
                updateClientScreen.Show();
                this.Hide();
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
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Email", typeof(string));
            //  table.Columns.Add("Tel", typeof(int));
            table.Columns.Add("Adress", typeof(string));

            // Step 3: here we add rows.
            ClientDAO clientDAO = new ClientDAO();
            try { 
            List<Client> clients = clientDAO.getClientsList();
            if (clients != null) { 
            clients.ForEach(item => {
                var row = table.NewRow();
                row["code"] = item.Code;
                row["Name"] = item.Name;
                row["LastName"] = item.LastName;
                row["Email"] = item.Email;
                row["Adress"] = item.Adress;

                table.Rows.Add(row);
            });
        }
            else
            {
                throw new exceptions("The Clients list is empty");
    }
}
            catch (exceptions exception)
{
    MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK);

}

return table;
        }
    }
}
