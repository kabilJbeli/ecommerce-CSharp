using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    interface clientInterface
    {
        void setClient();
        Client GetClient();
        void removeClient();
        Client updateClient();
        List<Client> getClientsList();


    }
}
