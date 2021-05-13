using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    class PRODUIT_EXISTE_EXCEPTION : Exception
    {
        public PRODUIT_EXISTE_EXCEPTION(string message) : base(message)
        {
        }
    }

    class ClIENT_EXISTE_EXCEPTION : Exception
    {
        public ClIENT_EXISTE_EXCEPTION(string message) : base(message)
        {
        }
    }

    class PAS_DE_PRODUITS_EXCEPTION : Exception
    {
        public PAS_DE_PRODUITS_EXCEPTION(string message) : base(message)
        {
        }
    }

    class PAS_DE_TRANSACTION_EXCEPTION : Exception
    {
        public PAS_DE_TRANSACTION_EXCEPTION(string message) : base(message)
        {
        }
    }

    class INSUFFICIENT_QUANTITY : Exception
    {
        public INSUFFICIENT_QUANTITY(string message) : base(message)
        {
        }
    }

    class EMPTY_TRANSACTIONS_LIST : Exception
    {
        public EMPTY_TRANSACTIONS_LIST(string message) : base(message)
        {
        }
    }
    class exceptions : Exception
    {
        public exceptions(string message) : base(message)
        {
        }
    }
}
