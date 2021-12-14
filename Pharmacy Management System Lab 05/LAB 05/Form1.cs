using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_05
{
    public partial class Form1 : Form
    {
        public int initial_balance = 0;
        List<Medicine> medicines = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Medicine_on_Click(object sender, EventArgs e)
        {
            string name = namebox.Text;
            string company = companybox.Text;
            int quantity = Convert.ToInt32(quantitybox.Text);
            int price = Convert.ToInt32(pricebox.Text);

            Medicine dummy = new Medicine();
            dummy.name = name;
            dummy.company = company;
            dummy.quantity = quantity;
            dummy.price = price;

            medicines.Add(dummy);
            MessageBox.Show("Medicine has been added successfully.");
        }

        private void Check_Availablity_on_Click(object sender, EventArgs e)
        {
            foreach(Medicine medicine in medicines)
            {
                if(avlnamebox.Text == medicine.name)
                {
                    string current_quantity=medicine.quantity.ToString();
                    MessageBox.Show("Available amount of medicine is " + current_quantity + " " + medicine.name);
                }
            }
        }

        private void Sell_Medicine_on_Click(object sender, EventArgs e)
        {
            foreach(Medicine medicine in medicines)
            {
                if(avlnamebox.Text ==medicine.name)
                {
                    if(Convert.ToInt32(avlquantitybox.Text)<=medicine.quantity && Convert.ToInt32(avlquantitybox.Text)>=0)
                            {
                        initial_balance+=(Convert.ToInt32(avlquantitybox.Text)*medicine.price);
                        medicine.quantity = medicine.quantity - Convert.ToInt32(avlquantitybox.Text);
                        MessageBox.Show("Current balance is " + initial_balance.ToString() + "$");
                        MessageBox.Show("Ammount left is " + medicine.quantity);
                    }
                }
            }
        }

        private void Check_Balance_on_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current balance is " + initial_balance.ToString() + "$");

        }

        private void Clear_on_Click(object sender, EventArgs e)
        {
            namebox.Text = String.Empty;
            companybox.Text = String.Empty;
            quantitybox.Text = String.Empty;
            pricebox.Text = String.Empty;
        }
    }
}
