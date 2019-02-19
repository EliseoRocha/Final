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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateCustomerList();
            PopulateBookList();
        }

        private void PopulateCustomerList()
        {
            List<Customer> customerList = CustomerDB.GetAllCustomers();

            CustomerComboBox.DataSource = customerList;

            CustomerComboBox.DisplayMember = nameof(Customer.FullName);
        }

        private void PopulateBookList()
        {
            List<Book> bookList = BookDB.GetAllBooks();

            BookComboBox.DataSource = bookList;

            BookComboBox.DisplayMember = nameof(Book.Title);
        }

        private void RegisterBookButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            Customer selCustomer = CustomerComboBox.SelectedItem as Customer;
            Book selBook = BookComboBox.SelectedItem as Book;

            reg.CustomerID = selCustomer.CustomerID;
            reg.ISBN = selBook.ISBN;
            reg.RegDate = dateTimePicker1.Value;

            BookRegistrationDB.RegisterBook(reg);
            MessageBox.Show("Registration Added!");

            DialogResult = DialogResult.OK;
            Close();
            //if (BookRegistrationDB.RegisterBook(selCustomer.CustomerID))
            //{

            //}
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CustomerComboBox.SelectedIndex = -1;
            BookComboBox.SelectedIndex = -1;
            dateTimePicker1.ResetText();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCust = new AddCustomerForm();
            DialogResult result = addCust.ShowDialog();

            PopulateCustomerList();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBook = new AddBookForm();
            DialogResult result = addBook.ShowDialog();

            PopulateBookList();
        }
    }
}
