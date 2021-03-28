using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    interface productInterface
    {
        void setProduct(Product product);
        Product GetProduct(string code);
        void removeProduct(string code);
        void updateProduct(Product product);
        List<Product> getProductsList();
    }
}
