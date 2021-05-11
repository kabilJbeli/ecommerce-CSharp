using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ecommerce.Validation
{
    class Validation
    {
       public static Match ValidateCode(string code)
        {
            Regex regex = new Regex("^[0-9]{1,10}$");
            Match match = regex.Match(code);
            return match;
        }

        public static Match ValidateTva(string code)
        {
            Regex regex = new Regex("");
            Match match = regex.Match(code);
            return match;
        }


        public static Match ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match;
        }

        public static Match ValidateTel(string tel)
        {
            Regex regex = new Regex("^[0-9]{8}$");
            Match match = regex.Match(tel);
            return match;
        }

        public static Match ValidateNaming(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z ]+$");
            Match match = regex.Match(name);
            return match;
        }

    }
}
