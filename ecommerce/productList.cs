using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class productList : ecommerce.Form1
    {
        public productList()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productList_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'ecommerceDataSet1.product'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productTableAdapter.Fill(this.ecommerceDataSet1.product);
            // TODO: cette ligne de code charge les données dans la table 'ecommerceDataSet.product'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productTableAdapter.Fill(this.ecommerceDataSet.product);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
