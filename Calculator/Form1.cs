using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 * 2018-10-07 - Created by Regina Curtis as personal learning project
 * 
 * */


namespace Calculator
{
    public partial class Form1 : Form
    {

        string input = string.Empty; //string to store user input
        string opperand1 = string.Empty; //string to store first opperand
        string opperand2 = string.Empty; //string to store second opperand
        char operation; //to store chosen operation
        double result = 0.0; //calculated result


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "0";  //add 0 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }
        private void btn_equals_Click(object sender, EventArgs e) //equals button
        {
            MessageBox.Show("hi gina");
            opperand2 = input;
            double num1, num2;
            double.TryParse(opperand1, out num1);
            double.TryParse(opperand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                txt_01.Text = result.ToString();
            }   
            else if (operation == '-')
            {
                result = num1 - num2;
                txt_01.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txt_01.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txt_01.Text = result.ToString();
                }
                else
                {
                    txt_01.Text = "Invalid - Unable to Divide by 0!";
                }

            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            opperand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "7";  //add 7 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "8";  //add 8 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user        
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "9";  //add 9 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "4";  //add 4 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "5";  //add 5 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "6";  //add 6 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "1";  //add 1 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "2";  //add 2 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "3";  //add 3 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void btn_period_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += ".";  //add . to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }



        private void btn_multiply_Click(object sender, EventArgs e)
        {
            opperand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            opperand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            opperand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = "";
            this.input = string.Empty;
            this.opperand1 = string.Empty;
            this.opperand2 = string.Empty;
        }
    }
}
