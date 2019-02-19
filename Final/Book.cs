using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Book
    {
        public string ISBN { get; set; }

        public double Price { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
