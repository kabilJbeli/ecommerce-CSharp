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
    public partial class updateTransactionScreen : ecommerce.Form1
    {
        public static string code;
        public updateTransactionScreen()
        {
            InitializeComponent();
        }

        private void updateTransactionScreen_Load(object sender, EventArgs e)
        {
            TransactionDAO transactionDAO = new TransactionDAO();
            Transaction transaction = transactionDAO.GetTransaction(code);
            this.statusLabel.Text = "Update Transaction";
            this.statusStrip1.Refresh();
            this.transactionCode.Enabled = false;
            this.transactionCode.Text = code;
            this.product.Text = transaction.Product.Name;
            this.client.Text = transaction.Client.Name;
        }





        private void addproductbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
