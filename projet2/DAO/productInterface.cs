using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    interface productInterface
    {
        Boolean setProduct(Product product);
        Product GetProduct(string code);
        void removeProduct(string code);
        Boolean updateProduct(Product product);
        List<Product> getProductsList();
    }
}
