using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Book currBook = new Book();
            currBook.ISBN = ISBNTextBox.Text;
            currBook.Price = Convert.ToDouble(PriceTextBox.Text);
            currBook.Title = TitleTextBox.Text;

            BookDB.AddBook(currBook);

            MessageBox.Show("Book Added!");
            Close();
        }
    }
}
