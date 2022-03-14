using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Gradebutton_Click(object sender, EventArgs e)
        {
            int attd, attd2, mid, final, q1, q2, q3, t1, t2;
            string name = Namebox.Text;
            string grade = "";
            attd = Convert.ToInt32(Attendbox.Text);
            mid = Convert.ToInt32(Midbox.Text);
            final = Convert.ToInt32(Finalbox.Text);
            q1 = Convert.ToInt32(QuizIbox.Text);
            q2 = Convert.ToInt32(QuizIIbox.Text);
            q3 = Convert.ToInt32(QuizIIIbox.Text);

            attd2 = attd + 2;
            Attbox.Text = attd2.ToString();
            Midmarksbox.Text = mid.ToString();
            Finalmarksbox.Text = final.ToString();
            t1 = q1 + q2 + q3;
            Quizbox.Text = t1.ToString();
            t2 = q1 + q2 + q3 + attd + mid + final;
            Totalbox.Text = t2.ToString();

            double percentage = (t2 / 300.0) * 100;

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

            Gradebox.Text = grade;

            Result.Text = name + " obtained " + Convert.ToString(percentage) + " % marks.";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
