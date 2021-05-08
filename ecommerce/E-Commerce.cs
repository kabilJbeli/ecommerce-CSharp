using ecommerce.ecommerceClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.statusLabel.Text = "Home";  
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajoutProduct(object sender, EventArgs e)
        {
            Console.WriteLine("button clicked");
            Product pd = new Product("dfdf9f89", "test", "tetlkmlk");
            ProductDAO dpd = new ProductDAO();
            dpd.setProduct(pd);
        }

        private void destroyForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gotoproductlist(object sender, EventArgs e)
        {

            productsList pd = new productsList();
            pd.Show();
            this.Hide();

        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientAdd f = new ClientAdd();
            f.Show();
            this.Hide();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void deleteProduct(object sender, EventArgs e)
        {
            removeProduct rP = new removeProduct();
            rP.Show();
            this.Hide();
        }

        private void clientListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientList cL = new clientList();
            cL.Show();
            this.Hide();
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeClient rC = new removeClient();
            rC.Show();
            this.Hide();
        }

        private void modifyClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateClient uC = new updateClient();
            uC.Show();
            this.Hide();
        }

        private void modifyProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateProduct uP = new updateProduct();
            uP.Show();
            this.Hide();
        }

        private void createATransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTransaction addTransaction = new addTransaction();
            addTransaction.Show();
            this.Hide();
        }

        private void transactionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            transactionList transactionList = new transactionList();
            transactionList.Show();
            this.Hide();

        }

        private void deleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeTransaction rmTransaction = new removeTransaction();
            rmTransaction.Show();
            this.Hide();
        }

        private void modifyTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateTransaction UpdateTransaction = new updateTransaction();
            UpdateTransaction.Show();
            this.Hide();
        }
    }
}
