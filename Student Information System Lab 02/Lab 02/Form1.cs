using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class UMS : Form
    {
        List<Student> students = new List<Student>();
        public UMS()
        {
            InitializeComponent();
        }

        private void Save_on_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studentidbox.Text);
            string name = studentnamebox.Text;
            string department = departmentbox.Text;
            string semester = semesterbox.Text;

            Student dummy = new Student();
            dummy.id = id;
            dummy.name = name;
            dummy.semester = semester;
            dummy.department = department;

            students.Add(dummy);

            MessageBox.Show("Student has been added Successfully");

        }

        private void Clear_on_Click(object sender, EventArgs e)
        {

        }

        private void UMS_Load(object sender, EventArgs e)
        {

        }

        private void teachersavebutton_Click(object sender, EventArgs e)
        {

        }

        private void studentshowbutton_Click(object sender, EventArgs e)
        {
            studentlistbox.Items.Clear();
            foreach(Student student in students)
            {
                studentlistbox.Items.Add(student.getInfo());
            }
        }

        private void teacherclearbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
