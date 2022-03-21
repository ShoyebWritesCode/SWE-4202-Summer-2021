using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollment_Dependencies
{
    public class Course
    {
       public string title, Level, EnrollmentDate;
       public int fee;

        public Course(string title, string level,  int fee)
        {
            this.title = title;
            this.Level = level;
            this.fee = fee;
        }

        public string getCourseInfo()
        {
            string info = title + "\t" + Level + "\t" + EnrollmentDate;
            return info;
        }
    }
}
