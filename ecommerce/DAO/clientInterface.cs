using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    interface clientInterface
    {
        Boolean setClient(Client client);
        Client GetClient(string code);
        void removeClient(string code);
        Boolean updateClient(Client client);
        List<Client> getClientsList();

    }
}
