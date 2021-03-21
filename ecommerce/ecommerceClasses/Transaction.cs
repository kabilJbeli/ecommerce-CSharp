using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    class Transaction
    {
        private int code;
        private DateTime transactionDate;

        public Transaction(int code, DateTime transactionDate)
        {
            this.code = code;
            this.transactionDate = transactionDate;
        }

        public int Code { get => code; set => code = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }

        public override bool Equals(object obj)
        {
            return obj is Transaction transaction &&
                   code == transaction.code &&
                   transactionDate == transaction.transactionDate;
        }
    }
}
