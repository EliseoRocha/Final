using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    static class BookRegistration
    {
        public static List<Registration> RegisterBook()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = "SELECT CustomerID" +
                                " ,ISBN" +
                                " ,RegDate";
            con.Open();

            SqlDataReader rdr = selCmd.ExecuteReader();

            List<Registration> registrations = new List<Registration>();
            while (rdr.Read())
            {
                Registration temp = new Registration();
                temp.CustomerID = (int)rdr["CustomerID"];
                temp.ISBN = (string)rdr["ISBN"];
                temp.RegDate = (DateTime)rdr["RegDate"];

                registrations.Add(temp);
            }

            con.Dispose();

            return registrations;

        }
    }
}
