using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class book
    {
        public string ID, name, author, publisher;
        public int quantity;

       //public string getInfo()
        
            
        
    public string borrowBook()
    {
        string Quantity = Convert.ToString(quantity - 1);
            quantity = quantity - 1;
            return Quantity;
    }
    }

}
