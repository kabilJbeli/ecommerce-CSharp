using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    class Transaction
    {
        private string code;
        private DateTime transactionDate;

        private Product product;
        private Client client;
        private int quantity;
        public Transaction()
        {

        }
        public Transaction(string code, DateTime transactionDate, Product product, Client client)
        {
            this.code = code;
            this.transactionDate = transactionDate;
            this.product = product;
            this.client = client;
        }

        public string Code { get => code; set => code = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public Product Product { get => product; set => product = value; }
        public Client Client { get => client; set => client = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public override bool Equals(object obj)
        {
            return obj is Transaction transaction &&
                   code == transaction.code &&
                   transactionDate == transaction.transactionDate;
        }

        public override int GetHashCode()
        {
            int hashCode = 1458268427;
            hashCode = hashCode * -1521134295 + code.GetHashCode();
            hashCode = hashCode * -1521134295 + transactionDate.GetHashCode();
            return hashCode;
        }

        static string myconstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
    }
}
