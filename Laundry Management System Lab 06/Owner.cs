using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    internal class Owner
    {
        public int balance = 0;
        public int iron = 5, wash = 7, both = 12;

        public void addBalance(int amount)
        {
            balance = balance + amount;
        }
        public int getBalance()
        {
            return balance;
        }
    }
}
