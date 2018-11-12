/*
 * 
 * 2018-10-07 - Created by Regina Curtis as personal learning project
 * 
 */

using System;
using System.Windows.Forms;



namespace Calculator
{
    public partial class Form1 : Form
    {

        //Variables
        string input = string.Empty; //string to store user input
        string operand1 = string.Empty; //string to store first value
        string operand2 = string.Empty; //string to store second value
        string operation = string.Empty; //to store chosen operation
        decimal result = 0; //calculated result


        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Zero_Click(object sender, EventArgs e)
        {
            CreateValues("0");
        }

        private void Btn_One_Click(object sender, EventArgs e)
        {
            CreateValues("1");
        }
        private void Btn_Two_Click(object sender, EventArgs e)
        {
            CreateValues("2");
        }

        private void Btn_Three_Click(object sender, EventArgs e)
        {
            CreateValues("3");
        }

        private void Btn_Four_Click(object sender, EventArgs e)
        {
            CreateValues("4");
        }

        private void Btn_Five_Click(object sender, EventArgs e)
        {
            CreateValues("5");
        }

        private void Btn_Six_Click(object sender, EventArgs e)
        {
            CreateValues("6");
        }

        private void Btn_Seven_Click(object sender, EventArgs e)
        {
            CreateValues("7");
        }

        private void Btn_Eight_Click(object sender, EventArgs e)
        {
            CreateValues("8");
        }

        private void Btn_Nine_Click(object sender, EventArgs e)
        {
            CreateValues("9");
        }
        
        private void Btn_Period_Click(object sender, EventArgs e)
        {
            if(!this.txt_01.Text.Contains("."))
            {
                CreateValues(".");
            }
                        
        }

        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            SetOperation("/");
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            SetOperation("*");
        }

        private void Btn_Subtract_Click(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }   

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = "";
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.operation = string.Empty;
            
        }

        //Allow user to delete values
        private void Btn_Backspace_Click(object sender, EventArgs e)
        {
            //check if the input variable is null
            if (operand2 != string.Empty)  
            {
                //if it isn't remove the last character
                operand2 = operand2.Remove(operand2.Length - 1, 1);
                this.txt_01.Text = operand2;
            }

            else if (operand1 != string.Empty)
            {
                operand1 = operand1.Remove(operand1.Length - 1, 1);
                this.txt_01.Text = operand1;
            }
                        
        }

        private void Btn_Equals_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hi gina");
            decimal num1, num2;  //variables to hold values for computations
            decimal.TryParse(operand1, out num1); //move values 
            decimal.TryParse(operand2, out num2); //move values
            
            if (operation == "+")  //add values together
            {
                result = num1 + num2;
                txt_01.Text = result.ToString("#,###.################################");  //display with commas
            }   
            else if (operation == "-") //subtract 1st value from 2nd
            {
                result = num1 - num2;
                txt_01.Text = result.ToString("#,###.################################"); //display value with commas
            }
            else if (operation == "*") //mulitply values together
            {
                result = num1 * num2;
                txt_01.Text = result.ToString("#,###.################################");
            }
            else if (operation == "/") //divide 1st value into second value
            {
                if (num2 != 0) //make sure second value isn't 0
                {
                    result = num1 / num2;
                    txt_01.Text = result.ToString("#,###.################################");
                }
                else  //if value is 0 display error message
                {
                    txt_01.Text = "Invalid - Unable to Divide by 0!";
                }
            }

            operation = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;

        }

        //Open new window for dollars to euros conversion
        private void BtnDollarsToEuros_Click(object sender, EventArgs e)
        {

            this.Hide();

            //show euro to dollars form
            using (var newWindow = new EurosToDollarsForm())

            {
                newWindow.Location = this.Location;
                newWindow.ShowDialog();
                //once new form is open, get rid of the old form
                
            }

            this.Show();
        }

        private void CreateValues (string numeric)
        {
           if (operation == string.Empty) 
            {
                operand1 += numeric;
                this.txt_01.Text = operand1;
            }

           else 
            {
                operand2 += numeric;
                this.txt_01.Text = operand2;
            }
        }

        private void SetOperation(string o)
        {
            if(operand1 != string.Empty)
            {
                operation = o;
            }
        }

    }
}