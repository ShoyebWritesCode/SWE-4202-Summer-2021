using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<user> Users = new List<user>();
        List<book> Books = new List<book>();
        private void addUser(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string ID = userIDTextBox.Text;
            string address = addressTextBox.Text;

            user users = new user();
            users.name = name;
            users.id = ID;
            users.address = address;

            Users.Add(users);
            MessageBox.Show("User Saved!");
        }

        private void addBook(object sender, EventArgs e)
        {
            string name = bookNameTextBox.Text;
            string ID = bookIDTextBox.Text;
            string author = authorTextBox.Text;
            string publisher = publisherTextBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            book books = new book();
            books.name = name;
            books.ID = ID;
            books.author = author;
            books.publisher = publisher;
            books.quantity = quantity;

            Books.Add(books);
            MessageBox.Show("Book Uploaded!");
        }

        private void borrowBookClick(object sender, EventArgs e)
        {
            string ID = addUserIDTextBox.Text;
            string bookID = addBookIDTextBox.Text;

            for(int i = 0; i < Books.Count; i++)
            {
                if(Books[i].ID == bookID)
                {
                    if (Books[i].quantity > 0)
                    {
                        
                       // Books[i].borrowBook();

                        MessageBox.Show("Thanks for Borrowing!");
                    }
                    else
                    {
                        MessageBox.Show("Book not available");
                    }
                }
            }
            for(int i=0; i < Users.Count; i++)
            {
                if(Users[i].id == ID)
                {
                    Users[i].bookID = bookID;
                }
            }
            
        }

        private void userIDShowClick(object sender, EventArgs e)
        {
            string userID = checkUserIDTexxtBox.Text;

            for(int i = 0; i < Users.Count; i++)
            {
                if (Users[i].id == userID)
                {
                    listBox.Items.Clear();
                    listBox.Items.Add(Users[i].getInfo());
                    string num = Users[i].bookID;
                    for(int j = 0; j < Books.Count; j++)
                    {
                        if(num== Books[j].ID)
                        {
                            string name = Books[j].name;
                            listBox.Items.Add(name);
                        }
                    }
                }
            }
        }

        private void showBookIdClick(object sender, EventArgs e)
        {
            string ID = showBookIDTextBox.Text;

            for(int i = 0; i < Books.Count; i++)
            {
                if(ID == Books[i].ID)
                {
                    label10.Text = Books[i].ID;
                    label9.Text = Books[i].name;
                    label8.Text = Books[i].author;
                    label7.Text = Books[i].publisher;
                    label6.Text = Convert.ToString(Books[i].quantity);
                }
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
