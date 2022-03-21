using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCourseEnrollment_Dependencies;

namespace StudentCourseEnrollment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> studentList = new List<Student>();
        List<Professional> professionalList = new List<Professional>();
        List<Course> courseList = new List<Course>();
        string type, level, Level;
        int fee;
        string studLevel, courseLevel;

        private void button3_Click(object sender, EventArgs e)
        {
            string course = selectCourseComboBox.Text;
            string studentReg = selectParticipantComboBox.Text;
            string date = enrollmentDateComboBox.Text;

            for(int i = 0; i < studentList.Count; i++)
            {
                if(studentReg == studentList[i].Reg_No)
                {
                    studLevel = studentList[i].Level;
                }
            }

            for (int i = 0; i < professionalList.Count; i++)
            {
                if (studentReg == professionalList[i].Reg_No)
                {
                    studLevel = professionalList[i].Level;
                }
            }

            for(int i=0;i< courseList.Count; i++)
            {
                if(course == courseList[i].title)
                {
                    courseLevel = courseList[i].Level;
                }
            }

            if (courseLevel == studLevel)
            {
                for (int i = 0; i < courseList.Count; i++)
                {
                    if (course == courseList[i].title)
                    {
                        fee = courseList[i].fee;
                        courseList[i].EnrollmentDate = date;

                    }
                }
                for (int i = 0; i < studentList.Count; i++)
                {
                    if (studentReg == studentList[i].Reg_No)
                    {
                        studentList[i].Course = course;
                        label17.Text = Convert.ToString(studentList[i].getCourseFee(fee));
                    }
                }
                for (int i = 0; i < professionalList.Count; i++)
                {
                    if (studentReg == professionalList[i].Reg_No)
                    {
                        professionalList[i].Course = course;
                        label17.Text = Convert.ToString(professionalList[i].getCourseFee(fee));
                    }
                }
                selectStudentComboBox.Items.Add(studentReg);

                MessageBox.Show("Enrolled");
            }
            else
            {
                label17.Text = "";
                MessageBox.Show("Course is on " + courseLevel + " Level but Participant is on " + studLevel + " Level!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Name \t Level \t Date \t Fee");
            string studentReg = selectStudentComboBox.Text;

            for(int i = 0; i<studentList.Count; i++)
            {
                if(studentReg == studentList[i].Reg_No)
                {
                    string course = studentList[i].Course;

                    for(int j=0; j<courseList.Count; j++)
                    {
                        if(course == courseList[j].title)
                        {
                            listBox1.Items.Add(courseList[j].getCourseInfo() + studentList[i].getCourseFee(courseList[j].fee));
                        }
                    }
                }
            }

            for (int i = 0; i < professionalList.Count; i++)
            {
                if (studentReg == professionalList[i].Reg_No)
                {
                    string course = professionalList[i].Course;

                    for (int j = 0; j < courseList.Count; j++)
                    {
                        if (course == courseList[j].title)
                        {
                            listBox1.Items.Add(courseList[j].getCourseInfo() + "\t" + professionalList[i].getCourseFee(courseList[j].fee));
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = titleTextbox.Text;
            int fee = Convert.ToInt32(courseFeeTextBox.Text);
            
            if(radioButton8.Checked == true)
            {
                Level = "Beginner";
            }
            else if (radioButton7.Checked == true)
            {
                Level = "Intermediate";
            }
            else if (radioButton6.Checked == true)
            {
                Level = "Advanced";
            }
            Course course = new Course(title, Level, fee);
            courseList.Add(course);
            selectCourseComboBox.Items.Add(title);

            MessageBox.Show("Course Added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string regNo = regNoTextBox.Text;
            string contact = contactTextBox.Text;
            string mail = emailTextBox.Text;
            
            
            if(radioButton1.Checked == true)
            {
                type = "student";
            }
            else if(radioButton2.Checked == true)
            {
                type = "professional";
            }

            if(radioButton3.Checked == true)
            {
                level = "Beginner";
            }
            else if (radioButton4.Checked == true)
            {
                level = "Intermediate";
            }
            else if (radioButton5.Checked == true)
            {
                level = "Advanced";
            }
            else if(radioButton3.Checked ==false && radioButton4.Checked == false && radioButton5.Checked == false && type == "student")
            {
                Student student = new Student(name, regNo, contact, mail);
                level = "Beginner";
                student.Level = level;
                studentList.Add(student);
            }
            else if (radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && type == "professional")
            {
                Professional professional = new Professional(name, regNo, contact, mail);
                level = "Beginner";
                professional.Level = level;
                professionalList.Add(professional);
            }

            if (type == "student" && level != "")
            {
                Student student = new Student(name, regNo, contact, mail,level);
                studentList.Add(student);
            }
            else if (type == "professional" && level != "")
            {
                Professional professional = new Professional(name, regNo, contact, mail, level);
                professionalList.Add(professional);
            }

            selectParticipantComboBox.Items.Add(regNo);

            MessageBox.Show("Participant Added");
        }
    }
}
