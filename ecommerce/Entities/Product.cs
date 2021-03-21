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
    }
}
