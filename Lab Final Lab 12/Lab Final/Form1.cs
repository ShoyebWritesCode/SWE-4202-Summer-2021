using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\Users\Dell\OneDrive\Desktop\Downloads\xxx.csv"))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student std = new Student();

                    std.ID = values[0];
                    std.name = values[1];
                    std.atd = values[2];
                    std.q1 = values[3];
                    std.q2 = values[4];
                    std.q3 = values[5];
                    std.q4 = values[6];
                    std.mid = values[7];
                    std.fin = values[8];
                    std.viva = values[9];



                    students.Add(std);
                }

                for (int i = 0; i < students.Count; i++)
                {
                    listBox1.Items.Add(students[i].ID);
                    listBox2.Items.Add(students[i].name);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == ID)
                {
                    label11.Text = students[i].q1;
                    label12.Text = students[i].q2;
                    label13.Text = students[i].q3;
                    label14.Text = students[i].q4;
                    label16.Text = students[i].atd;
                    label17.Text = students[i].mid;
                    label18.Text = students[i].fin;
                    label19.Text = students[i].viva;

                    int a1, a2, a3, a4,qt, attd, midx, finx, viv, total;
                    string grade = "";

                    a1 = Convert.ToInt32(label11.Text);
                    a2 = Convert.ToInt32(label12.Text);
                    a3 = Convert.ToInt32(label13.Text);
                    a4 = Convert.ToInt32(label14.Text);

                    attd = Convert.ToInt32(label16.Text);
                    midx = Convert.ToInt32(label17.Text);
                    finx = Convert.ToInt32(label18.Text);
                    viv = Convert.ToInt32(label19.Text);

                    qt = a1+ a2 + a3;
                    total = qt+ attd + midx + finx + viv;

                    label15.Text = Convert.ToString(qt);
                    label21.Text = Convert.ToString(total);

                    double percentage = (total / 300.0) * 100;

                    if (percentage >= 80)
                    {
                        grade = "A+";
                    }
                    else if (percentage >= 75 && percentage < 80)
                    {
                        grade = "A";
                    }
                    else if (percentage >= 70 && percentage < 75)
                    {
                        grade = "A-";
                    }
                    else if (percentage >= 65 && percentage < 70)
                    {
                        grade = "B+";
                    }
                    else if (percentage >= 60 && percentage < 65)
                    {
                        grade = "B";
                    }
                    else if (percentage >= 55 && percentage < 60)
                    {
                        grade = "B-";
                    }
                    else if (percentage >= 50 && percentage < 55)
                    {
                        grade = "C+";
                    }
                    else if (percentage >= 45 && percentage < 50)
                    {
                        grade = "C";
                    }
                    else if (percentage >= 40 && percentage < 45)
                    {
                        grade = "D";
                    }
                    else if (percentage < 40)
                    {
                        grade = "F";
                    }

                    label23.Text = grade;

               
                }
                
            }
     
        }
    }
}
