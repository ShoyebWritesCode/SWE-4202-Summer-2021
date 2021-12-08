using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2
{
    internal class Book
    {
        public string  Title, Author, Publisher;
        public int ID, Quantity;

        public int borrowBook()
        {
            Quantity = Quantity - 1;
            return Quantity;
        }
    }
}
