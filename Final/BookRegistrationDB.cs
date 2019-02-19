using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class BookRegistrationDB
    {
        public static void RegisterBook(Registration reg)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO Registration(CustomerID" +
                                    " ,ISBN" +
                                    " ,RegDate)" +
                                    " VALUES(@CustomerID, @ISBN, @RegDate)";
            insertCmd.Parameters.AddWithValue("@CustomerID", reg.CustomerID);
            insertCmd.Parameters.AddWithValue("@ISBN", reg.ISBN);
            insertCmd.Parameters.AddWithValue("@RegDate", reg.RegDate);

            con.Open();

            int rows = insertCmd.ExecuteNonQuery();

            if (rows == 1)
            {

            }
        }
    }
}
