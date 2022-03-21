using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_10
{
    internal class employee
    {
        public string id;
        public string first_name;
        public string last_name;
        public string email;
        public string phone_number;
        public string hire_date;
        public string job_id;
        public string salary;

        public string GetInfo()
        {
            return id + "\t" + first_name + "\t" + last_name;
        }
    }
}
