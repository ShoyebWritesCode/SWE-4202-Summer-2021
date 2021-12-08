using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2
{
    internal class ResearchArticle:Book
    {
        public string DOI, PubDate, CorJ;

        public string getInfo()
        {
            string info = Convert.ToString(ID) + "\t" + Title + "\t" + Author + "\t" + DOI + "\t" + Convert.ToString(Quantity) + "\t" + CorJ;
            return info;
        }
    }
}
