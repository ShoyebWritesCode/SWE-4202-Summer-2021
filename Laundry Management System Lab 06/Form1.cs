using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<User> Users = new List<User>();
        // List<Owner> Owners = new List<Owner>();
        Owner owner = new Owner();
        List<Order> Orders = new List<Order>();

        private void createAccButton_Click(object sender, EventArgs e)
        {
            
            string userID = textBox4.Text;
            string name = textBox3.Text;
            string address = textBox2.Text;

            User users = new User(userID, name, address);

            Users.Add(users);

            MessageBox.Show("User Added");

            
        }
        public int i = 0, amount;
        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            

            string ID = textBox5.Text;
            int shirtQuantity = Convert.ToInt32(textBox6.Text);
            int pantQuantity = Convert.ToInt32(textBox7.Text);
            int suitQuantity = Convert.ToInt32(textBox8.Text);
            int bedSheetQuantity = Convert.ToInt32(textBox9.Text);
            string toDoshirt = comboBox2.Text;
            string toDopant = comboBox5.Text;
            string toDosuit = comboBox4.Text;
            string toDobedSheet = comboBox3.Text;


            Order order = new Order();
            order.ID = i;
            order.shirtQuantity = shirtQuantity;
            order.pantQuantity = pantQuantity;
            order.suitQuantity = suitQuantity;
            order.bedSheetQuantity = bedSheetQuantity;
            order.to_doShirt = toDoshirt;
            order.to_doPant = toDopant;
            order.to_doSuit = toDosuit;
            order.to_doBedSheet = toDobedSheet;
            order.status = "Pending";

            Orders.Add(order);

            for(int j = 0; j < Users.Count; j++)
            {
                if (ID == Users[j].ID)
                {
                    order.name = Users[j].name;
                    order.address = Users[j].address;
                }
            }

            int m=0, n=0, o=0;
            if(toDoshirt== "Wash ")
            {
                n = n + shirtQuantity;
            }
            else if(toDoshirt== "Iron")
            {
                m = m + shirtQuantity;
            }
            else if(toDoshirt== "Both")
            {
                o = o + shirtQuantity;
            }

            if(toDopant == "Wash ")
            {
                n = n + pantQuantity;
            }
            else if (toDopant == "Iron")
            {
                m = m + pantQuantity;
            }
            else if (toDopant == "Both")
            {
                o = o + pantQuantity;
            }

            if(toDosuit == "Wash ")
            {
                n = n + suitQuantity;
            }
            else if (toDosuit == "Iron")
            {
                m = m + suitQuantity;
            }
            else if (toDosuit == "Both")
            {
                o = o + suitQuantity;
            }

            if (toDobedSheet == "Wash ")
            {
                n = n + bedSheetQuantity;
            }
            else if (toDobedSheet == "Iron")
            {
                m = m + bedSheetQuantity;
            }
            else if (toDobedSheet == "Both")
            {
                o = o + bedSheetQuantity;
            }

             amount = order.getIronAmount(m) + order.getWashAmount(n) + order.getBothAmount(o);

            order.amount1 = amount;

            MessageBox.Show("Your Order ID is " + i +" and Order amount:" + amount);

            i++;
        }

        private void setStatusButton_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(textBox1.Text);
            string status = comboBox1.Text;

            for(int j = 0; j < Orders.Count; j++)
            {
                if(orderID == Orders[j].ID)
                {
                    Orders[j].status = status;

                    if (status == "Delivered")
                    {
                        owner.addBalance(Orders[j].amount1);
                        label5.Text = Convert.ToString(owner.getBalance());
                    }
                }

            }

            
        }

        private void seeOrderDetailsButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int ID = Convert.ToInt32(textBox10.Text);

            listBox1.Items.Add("Type\t\t Quantity\t To_Do\t Amount");

            for (int j = 0; j < Orders.Count; j++)
            {
                if(ID == Orders[j].ID)
                {
                    label19.Text = Orders[j].status;
                    label20.Text = Convert.ToString(Orders[j].amount1);

                    if (Orders[j].shirtQuantity > 0)
                    {
                        listBox1.Items.Add(Orders[j].getShirtOrderInfo());
                    }
                    if (Orders[j].pantQuantity > 0)
                    {
                        listBox1.Items.Add(Orders[j].getPantOrderInfo());
                    }
                    if (Orders[j].suitQuantity > 0)
                    {
                        listBox1.Items.Add(Orders[j].getSuitOrderInfo());
                    }
                    if (Orders[j].bedSheetQuantity > 0)
                    {
                        listBox1.Items.Add(Orders[j].getBedSheetOrderInfo());
                    }
                }
            }
            for(int j = 0; j < Users.Count; j++)
            {
                if(ID == Orders[j].ID)
                {
                    label21.Text = Orders[j].name;
                    label22.Text = Orders[j].address;
                }
            }
        }
    }
}

