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
    public partial class addTransaction : ecommerce.Form1
    {
        private int selectedClientIndex,selecteProductIndex;
        public addTransaction()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void productCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void productBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addTransaction_Load(object sender, EventArgs e)
        {
            ProductDAO productDao = new ProductDAO();
            List<Product> products = productDao.getProductsList();
            products.ForEach(item =>
            {
                this.product.Items.Add(item.Name);

            });

            ClientDAO clientDao = new ClientDAO();
            List<Client> clients = clientDao.getClientsList();

            clients.ForEach(item =>
            {
                this.client.Items.Add(item.Name);

            });


        }

        private void clients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addproductbtn_Click(object sender, EventArgs e)
        {
            TransactionDAO transactionDAO = new TransactionDAO();
            Transaction transaction = new Transaction();

            ClientDAO clientDAO = new ClientDAO();
            Client client = new Client();
            this.selectedClientIndex =  this.client.SelectedIndex;
            client = clientDAO.getClientsList()[this.selectedClientIndex];
            Product product = new Product();
            ProductDAO productDAO = new ProductDAO();
            this.selecteProductIndex = this.product.SelectedIndex;
            product = productDAO.getProductsList()[this.selecteProductIndex];
            transaction.Client = client;
            transaction.Product = product;
            transaction.Code = this.transactionCode.Text;
            transactionDAO.setTransaction(transaction);
        }
    }
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
