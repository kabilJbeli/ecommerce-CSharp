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
        Product GetProduct();
        void removeProduct();
        Product updateProduct(Product product);
        List<Product> getProductsList();

    }
}
