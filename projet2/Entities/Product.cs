using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    class Product
    {
        private string code;
        private string name;
        private string brand;
        private int quantity;
        private decimal tva;
        private decimal prixUnitaire;
        public Product()
        {

        }

        public Product(string code, string name, string brand)
        {
            this.Code = code;
            this.Name = name;
            this.Brand = brand;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Tva { get => tva; set => tva = value; }
        public decimal PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }

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

        static string myconstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

    }
}
