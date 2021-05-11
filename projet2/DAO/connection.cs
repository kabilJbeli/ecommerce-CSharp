using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.DAO
{
   static  class connection
    {
        static string myconstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

       public  static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(myconstrng);
            return conn;
        }
    }
}
