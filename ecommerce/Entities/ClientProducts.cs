using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Entities
{
    class ClientProducts
    {
        private string clientCode;
        private string productCode;
        private int quantity;
        public ClientProducts()
        {

        }
        public ClientProducts(string clientCode, string productCode, int quantity)
        {
            this.clientCode = clientCode;
            this.productCode = productCode;
            this.quantity = quantity;
        }

        public string ClientCode { get => clientCode; set => clientCode = value; }
        public string ProductCode { get => productCode; set => productCode = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        static string myconstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public override bool Equals(object obj)
        {
            return obj is ClientProducts products &&
                   clientCode == products.clientCode &&
                   productCode == products.productCode &&
                   quantity == products.quantity;
        }

        public override int GetHashCode()
        {
            int hashCode = 602794588;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(productCode);
            hashCode = hashCode * -1521134295 + quantity.GetHashCode();
            return hashCode;
        }
    }
}
