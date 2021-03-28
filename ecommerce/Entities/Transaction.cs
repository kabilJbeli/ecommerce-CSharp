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

        public Transaction()
        {

        }
        public Transaction(string code, DateTime transactionDate)
        {
            this.code = code;
            this.transactionDate = transactionDate;
        }

        public string Code { get => code; set => code = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }

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
