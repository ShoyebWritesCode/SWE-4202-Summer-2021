using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2
{
    internal class StudyBook:Book
    {
        
        public string ISBN, Genre;

        public string getInfo()
        {
            string info = Convert.ToString(ID) + "\t" + Title + "\t" + Author + "\t" + ISBN + "\t" + Convert.ToString(Quantity);
            return info;
        }
    }
}
