using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    static class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            string dbCon = "Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True;";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbCon;
            return con;
        }
    }
}
