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
            this.quantity.Text = transaction.Quantity.ToString();
            this.product.Text = transaction.Product.Name;
            this.client.Text = transaction.Client.Name;
            this.product.Enabled = false;
            this.client.Enabled = false;
        }






        private void addproductbtn_Click_1(object sender, EventArgs e)
        {
            TransactionDAO transactionDAO = new TransactionDAO();
            Transaction transaction = new Transaction();
            transaction.Code = code;
            transaction.Quantity = int.Parse(this.quantity.Text);
            try
            {
                if (transaction.Product.Quantity < transaction.Quantity)
                {
                    throw new INSUFFICIENT_QUANTITY("There's not a susfficiant Quantity to accept your transaction");
                }
                transactionDAO.updateTransaction(transaction);
            }catch(INSUFFICIENT_QUANTITY exception)
            {
                string title = "Exception";
                string message = exception.Message;
                MessageBox.Show(message, title);

            }
        }
    }
}
