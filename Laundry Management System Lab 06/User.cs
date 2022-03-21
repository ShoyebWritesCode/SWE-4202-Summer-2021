using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    internal class User
    {
        public string ID, name, address;
        public int orderID;

        public User(string ID, string name, string address)
        {
            this.ID = ID;
            this.name = name;
            this.address = address;
        }

        public void calcAmount(int ironQuantity, int washQuantity, int bothQuantity)
        {
         //   amount =   (ironQuantity * 5) + (washQuantity * 7) + (bothQuantity * 12);
        }

        
    }
}
