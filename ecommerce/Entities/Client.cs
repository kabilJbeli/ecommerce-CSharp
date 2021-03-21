using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    class Client
    {

        private int code;
        private string name;
        private string lastName;
        private string email;
        private int tel;
        private string adress;

        public Client(int code, string name, string lastName, string email, int tel, string adress)
        {
            this.code = code;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.tel = tel;
            this.adress = adress;
        }

        public int Code { get => code; set => code = value; }
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
    }
}
