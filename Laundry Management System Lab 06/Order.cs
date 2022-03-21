using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    internal class Order
    {
        public string status;
        public int  amount =0, ID, amount1;
            public string   to_doShirt, to_doPant, to_doSuit, to_doBedSheet, name, address;
            public int shirtQuantity, pantQuantity, suitQuantity, bedSheetQuantity;


        public string getShirtOrderInfo()
            {
                string info = "Shirt" + "\t" + Convert.ToString(shirtQuantity) + "\t" + to_doShirt + "\t" + Convert.ToString(amount1);
                return info;
            }
            public string getPantOrderInfo()
            {
                string info = "Pant" + "\t" + Convert.ToString(pantQuantity) + "\t" + to_doPant + "\t" + Convert.ToString(amount1);
                return info;
            }
            public string getSuitOrderInfo()
            {
                string info = "Suit" + "\t" + Convert.ToString(suitQuantity) + "\t" + to_doSuit + "\t" + Convert.ToString(amount1);
                return info;
            }
            public string getBedSheetOrderInfo()
            {
                string info = "Bed-SHeet" + "\t" + Convert.ToString(bedSheetQuantity) + "\t" + to_doBedSheet + "\t" + Convert.ToString(amount1);
                return info;
            }
        public int getIronAmount(int n)
        {
            return (n * 5);
        }
        public int getWashAmount(int n)
        {
            return (n * 7);
        }
        public int getBothAmount(int n)
        {
            return (n * 12);
        }
    }
    }

