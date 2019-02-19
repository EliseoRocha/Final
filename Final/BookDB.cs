using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    static class BookDB
    {
        public static List<Book> GetAllBooks()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = "SELECT ISBN" +
                                " ,Price" +
                                " ,Title" +
                                " FROM Book";
            con.Open();

            SqlDataReader rdr = selCmd.ExecuteReader();

            List<Book> books = new List<Book>();
            while (rdr.Read())
            {
                Book temp = new Book();
                temp.ISBN = (string)rdr["ISBN"];
                temp.Price = Convert.ToDouble(rdr["Price"]);
                temp.Title = (string)rdr["Title"];

                books.Add(temp);
            }

            con.Dispose();

            return books;

        }

        public static void AddBook(Book book)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO Book(ISBN" +
                                    " ,Price" +
                                    " ,Title)" +
                                    " VALUES(@ISBN, @Price, @Title)";
            insertCmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            insertCmd.Parameters.AddWithValue("@Price", book.Price);
            insertCmd.Parameters.AddWithValue("@Title", book.Title);

            con.Open();

            int rows = insertCmd.ExecuteNonQuery();

            if (rows == 1)
            {

            }
        }
    }
}
