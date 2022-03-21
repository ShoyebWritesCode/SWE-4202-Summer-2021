using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_11
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turn)
                button.Text = "X";
            else
                button.Text = "O";

            turn = !turn;
            button.Enabled = false;
            turn_count++;

            if (turn == false)
                label1.Text = "Player 2's turn";
            else
                label1.Text = "Player 1's turn";



            checkWinner();
        }

        private void checkWinner()
        {
            bool Winner = false;

            if ((button1.Text==button2.Text)&&(button2.Text==button3.Text)&&(!button1.Enabled))
                Winner = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                Winner = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                Winner = true;

            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                Winner = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                Winner = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                Winner = true;

            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                Winner = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                Winner = true;
           

            if (Winner)
            {
                disableButtons();

                string win = "";
                if (turn)
                    win = "Player 2";
                else
                    win = "Player 1";

                MessageBox.Show(win + " wins");

            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Nobody" + " wins");
            }
        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }

                catch
                {

                }
                

            }
        }

        private void Reset_On_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                    button.Text = "";
                }

                catch
                {

                }


            }
        }
    }
}
