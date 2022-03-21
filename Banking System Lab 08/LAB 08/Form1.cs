using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_08
{
    public partial class Form1 : Form
    {
        int current = 0;
        List<Account>accounts = new List<Account>();
        List<Current>currents = new List<Current>();
        List<Savings> savings = new List<Savings>();
        List<Loan> loans = new List<Loan>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int amount = Convert.ToInt32(textBox2.Text);
            string account_no = textBox9.Text;
            string type = comboBox1.Text;

            Account dummy = new Account();
            dummy.name = name;
            dummy.amount = amount;
            dummy.account_no = account_no;
            accounts.Add(dummy);

            if (type == "Current")
            {
                label19.Text = "300";
                MessageBox.Show("Current Account Created.");
            }
            else if (type == "Savings")
            {
                label19.Text = "314";
                MessageBox.Show("Savings Account Created.");
            }
            else if (type == "Loan")
            {
                label19.Text = "400";
                MessageBox.Show("Loan Account Created.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Account account in accounts)
            {
                if (textBox3.Text == account.account_no)
                {
                    string deposit = textBox4.Text;
                    current += Convert.ToInt32(textBox4.Text) + account.amount;
                    string blnc = current.ToString();

                    MessageBox.Show("Deposit"+" " + deposit +" "+ "Successfull.");
                    MessageBox.Show("Current Balance" + " " + blnc);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Account account in accounts)
            {
                if (textBox5.Text == account.account_no)
                {
                    string withdraw = textBox6.Text;
                    current -= Convert.ToInt32(textBox6.Text);
                    string bln = current.ToString();

                    MessageBox.Show("Withdraw" + " " + withdraw + " " + "Successfull.");
                    MessageBox.Show("Current Balance" + " " + bln);

                }

            }
        }
    }
}
