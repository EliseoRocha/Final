using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    static class CustomerDB
    {
        public static List<Customer> GetAllCustomers()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = "SELECT CustomerID" +
                                " ,FirstName" +
                                " ,LastName" +
                                " ,DateOfBirth" +
                                " ,Title" +
                                " FROM Customer";
            con.Open();

            SqlDataReader rdr = selCmd.ExecuteReader();

            List<Customer> customers = new List<Customer>();
            while (rdr.Read())
            {
                Customer temp = new Customer();
                temp.CustomerID = (int)rdr["CustomerID"];
                temp.FirstName = (string)rdr["FirstName"];
                temp.LastName = (string)rdr["LastName"];
                temp.DateOfBirth = (DateTime)rdr["DateOfBirth"];
                temp.Title = (string)rdr["Title"];

                customers.Add(temp);
            }

            con.Dispose();

            return customers;

        }

        public static void AddCustomer(Customer cust)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO Customer(DateOfBirth, FirstName, LastName, Title)" +
                                    " VALUES(@DateOfBirth, @FirstName, @LastName, @Title)";
            insertCmd.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth);
            insertCmd.Parameters.AddWithValue("@FirstName", cust.FirstName);
            insertCmd.Parameters.AddWithValue("@LastName", cust.LastName);
            insertCmd.Parameters.AddWithValue("@Title", cust.Title);

            con.Open();

            int rows = insertCmd.ExecuteNonQuery();

            if (rows == 1)
            {
                //row was inserted successfully
            }
        }
    }
}
