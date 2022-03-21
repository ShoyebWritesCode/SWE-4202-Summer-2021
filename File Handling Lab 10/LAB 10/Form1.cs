using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<employee> employees = new List<employee>();
        ListBox employeeListbox = new ListBox();
        
        //List <DataGridView> dataGridViews = new List<DataGridView>();

        public DataTable ReadCSV(string fileName)
        {
            DataTable dt = new DataTable("Data");
            using(OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\""+Path.GetDirectoryName(fileName)
                +"\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                //using (OleDbCommandcmd = cn.CreateCommand())
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select *from[{0}]",new FileInfo(fileName).Name),cn))
                {
                    cn.Open();
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        private void Open_On_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                        dataGridView1.DataSource = ReadCSV(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employee dummy = new employee();
            using (var reader = new StreamReader(@"C:\Users\Dell\OneDrive\Desktop\Downloads\employees.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    dummy.id= values[0];
                    dummy.first_name= values[1];
                    dummy.last_name= values[2];
                    dummy.email= values[3];
                    dummy.phone_number= values[4];
                    dummy.hire_date= values[5];
                    dummy.job_id= values[6];
                    dummy.salary= values[7];
                    employees.Add(dummy);
                    employeeList.Items.Add(dummy.GetInfo());
                }
            }
        }
    }
}
