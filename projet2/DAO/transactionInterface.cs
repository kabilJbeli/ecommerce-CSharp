using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    interface transactionInterface
    {
        void setTransaction(Transaction transaction);
        Transaction GetTransaction(string code);
        void removeTransaction(string code);
        void updateTransaction(Transaction transaction);
        List<Transaction> getTransactionsList();
    }
}
