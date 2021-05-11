using ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.DAO
{
    interface clientProductsInterface
    {
         void setClientProducts(string clientCode, string productCode, int quantity);
         ClientProducts getClientCode();
    }
}
