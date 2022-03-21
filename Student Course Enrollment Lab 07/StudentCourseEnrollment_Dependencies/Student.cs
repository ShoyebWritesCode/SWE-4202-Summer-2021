using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollment_Dependencies
{
    public class Student:Participant
    {
        public int getCourseFee(int fee)
        {
            this.fee = fee;
            return fee;
        }

        public Student(string name, string reg, string contact, string mail, string Level)
        {
            this.name = name;
            this.Reg_No = reg;
            this.Contact = contact;
            this.Email = mail;
            this.Level = Level;
        }

        public Student(string name, string reg, string contact, string mail)
        {
            this.name = name;
            this.Reg_No = reg;
            this.Contact = contact;
            this.Email = mail;
            this.Level = "Beginner";
        }
    }
}
