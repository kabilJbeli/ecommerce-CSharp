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
    public partial class selectedClientRepartition : ecommerce.Form1
    {
        private string code;

        public selectedClientRepartition()
        {
            InitializeComponent();
        }

        public string Code { get => code; set => code = value; }

        private void selectedClientRepartition_Load(object sender, EventArgs e)
        {
            TransactionDAO transactionDao = new TransactionDAO();
            try { 
            List<Transaction> transactions = transactionDao.getTransactionsListByClientID(Code);
            this.statusLabel.Text = "Client Transaction Repartition";
            this.statusStrip1.Refresh();
            decimal total = 0;
            if(transactions != null) { 
            transactions.ForEach(item => {
                total = total+ (item.Product.PrixUnitaire * (1 + item.Product.Tva)) * item.Quantity;
            });
            clientChart.Series["Repartition"].Points.AddXY("Total Transactions By Client", total);

        }
                else
                {
                    throw new exceptions("There's currently no transaction for the selected product");
    }
}catch (exceptions exception)
{
    MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK);

}

        }
    }
}
