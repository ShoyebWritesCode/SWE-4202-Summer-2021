using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollment_Dependencies
{
    public class Professional:Participant
    {
        public double getCourseFee(int fee)
        {
             
            double extra = fee * 0.1;
            return fee + extra;
            this.fee = fee + extra;
        }
        public Professional(string name, string reg, string contact, string mail, string Level)
        {
            this.name = name;
            this.Reg_No = reg;
            this.Contact = contact;
            this.Email = mail;
            this.Level = Level;
        }

        public Professional(string name, string reg, string contact, string mail)
        {
            this.name = name;
            this.Reg_No = reg;
            this.Contact = contact;
            this.Email = mail;
            this.Level = "Beginner";
        }
    }
}
