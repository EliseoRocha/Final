using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Title { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
