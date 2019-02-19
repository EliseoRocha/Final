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
    public partial class AddCustomerForm : Form
    {

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer currCustomer = new Customer();

            currCustomer.DateOfBirth = dateTimePicker1.Value;
            currCustomer.FirstName = FirstNameTextBox.Text;
            currCustomer.LastName = LastNameTextBox.Text;
            currCustomer.Title = TitleTextBox.Text;

            CustomerDB.AddCustomer(currCustomer);

            MessageBox.Show("Customer Added!");
            Close();
        }
    }
}
