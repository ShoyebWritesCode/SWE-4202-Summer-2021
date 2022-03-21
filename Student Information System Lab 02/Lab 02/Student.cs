using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class Student
    {
       public int id;
       public string name;
       public string department;
       public string semester;

        public string getInfo()
        {
            string studentinfo = id.ToString()+"\t"+name+"\t"+department+"\t"+semester;
            return studentinfo;
        }
    }
}
