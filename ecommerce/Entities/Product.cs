using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    class Product
    {
        private int code;
        private string name;
        private string brand;

        public Product(int code, string name, string brand)
        {
            this.Code = code;
            this.Name = name;
            this.Brand = brand;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   code == product.code &&
                   name == product.name &&
                   brand == product.brand;
        }

        public override int GetHashCode()
        {
            int hashCode = 2086697472;
            hashCode = hashCode * -1521134295 + code.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(brand);
            return hashCode;
        }
    }
}
