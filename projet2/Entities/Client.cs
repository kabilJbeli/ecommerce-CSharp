using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    class Client
    {

        private string code;
        private string name;
        private string lastName;
        private string email;
        private int tel;
        private string adress;
        public Client()
        {

        }
        public Client(string code, string name, string lastName, string email, int tel, string adress)
        {
            this.code = code;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.tel = tel;
            this.adress = adress;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Adress { get => adress; set => adress = value; }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   code == client.code &&
                   name == client.name &&
                   lastName == client.lastName &&
                   email == client.email &&
                   tel == client.tel;
        }

        public override int GetHashCode()
        {
            int hashCode = 1996132284;
            hashCode = hashCode * -1521134295 + code.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(lastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + tel.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(adress);
            return hashCode;
        }

        static string myconstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
    }
}
