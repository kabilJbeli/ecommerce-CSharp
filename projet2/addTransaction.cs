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
        public void checkBtnState()
        {
            if (!Validation.Validation.ValidateCode(this.transactionCode.Text).Success 
                || !Validation.Validation.ValidateInteger(this.quantity.Text).Success
                )
            {

                this.addproductbtn.Enabled = false;
            }
            else
            {
                this.addproductbtn.Enabled = true;

            }

        }

        private void productCode_TextChanged(object sender, EventArgs e)
        {
            if (Validation.Validation.ValidateCode(this.transactionCode.Text).Success)
            {
                this.transactionCode.ForeColor = Color.Green;
            }
            else
            {
                this.transactionCode.ForeColor = Color.OrangeRed;
            }
            this.checkBtnState();
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
            this.checkBtnState();


        }

        private void clients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void transactionCode_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void product_TextChanged(object sender, EventArgs e)
        {
            this.checkBtnState();
        }

        private void client_TextChanged(object sender, EventArgs e)
        {
            this.checkBtnState();

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            if (Validation.Validation.ValidateInteger(this.quantity.Text).Success)
            {
                this.quantity.ForeColor = Color.Green;
            }
            else
            {
                this.quantity.ForeColor = Color.OrangeRed;

            }
            this.checkBtnState();
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
            transaction.Quantity = int.Parse(this.quantity.Text);
            try
            {if(product.Quantity < transaction.Quantity)
                {
                    throw new INSUFFICIENT_QUANTITY("There's not a susfficiant Quantity to accept your transaction");
                }
                transactionDAO.setTransaction(transaction);
            }catch(INSUFFICIENT_QUANTITY exception)
            {
                 string title = "Exception";
                string message = exception.Message;
                MessageBox.Show(this, message, title, MessageBoxButtons.OK);
            }
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
