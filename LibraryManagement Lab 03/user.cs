using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class user
    {
        public string id;
        public string name;
        public string address;
        public string bookID;

        public string getInfo()
        {
            string info = id + "\t" + name + "\t" + bookID ;
            return info;
        }
    }
}
