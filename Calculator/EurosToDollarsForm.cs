using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Calculator
{
    public partial class EurosToDollarsForm : Form
    {
        public EurosToDollarsForm()
        {
            InitializeComponent();
        }

        //Variables
        string input = string.Empty; //string to store user input

        private void Btn_Zero_Click(object sender, EventArgs e)
        {
            input += "0";  //add 0 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_One_Click(object sender, EventArgs e)
        {
            input += "1";  //add 1 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Two_Click(object sender, EventArgs e)
        {
            input += "2";  //add 2 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Three_Click(object sender, EventArgs e)
        {
            input += "3";  //add 3 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Four_Click(object sender, EventArgs e)
        {
            input += "4";  //add 4 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Five_Click(object sender, EventArgs e)
        {
            input += "5";  //add 5 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Six_Click(object sender, EventArgs e)
        {
            input += "6";  //add 6 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Seven_Click(object sender, EventArgs e)
        {
            input += "7";  //add 7 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Eight_Click(object sender, EventArgs e)
        {
            input += "8";  //add 8 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Nine_Click(object sender, EventArgs e)
        {
            input += "9";  //add 9 to existing value entered by user
            this.TxtDollarAmt.Text = input; //adds new value to text field to display to user
        }

        private void Btn_Period_Click(object sender, EventArgs e)
        {
            //check if period button has been pressed before, if so don't allow a second time
            if (input.Contains("."))
            {
                this.TxtDollarAmt.Text = input;
            }

            else
            {
                input += ".";  //add . to existing value entered by user
                this.TxtDollarAmt.Text = input; //adds value to text field to display to user
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = "";
            this.TxtEuroAmt.Text = "";
            this.input = string.Empty;
        }

        
                   
        private void Btn_Equals_Click(object sender, EventArgs e) //get dollar to euro amount
        {

            //variable for method
            string dataAmt = "";

            //Clear user entered amount
            this.TxtDollarAmt.Text = "";
            
            try
            {
                //get amounts from website
                WebRequest request = WebRequest.Create("http://free.currencyconverterapi.com/api/v5/convert?q=USD_EUR&compact=y");
              
                //Put website response into usable format
                using (WebResponse response = request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader responseReader = new StreamReader(dataStream);
                    //read the data
                    string json = responseReader.ReadToEnd();
                    //save value from webiste to use in calculation
                    dataAmt = JObject.Parse(json)["USD_EUR"]["val"].ToString();
                }                               
                
                //convert the amount returned into a number
                double conversionAmt = Convert.ToDouble(dataAmt);
                //convert user provided amount into a number
                double dollarAmt = Convert.ToDouble(input);
                //convert from euro to dollar
                double euroAmt = conversionAmt * dollarAmt;
                //display to user
                this.TxtEuroAmt.Text = Convert.ToString(euroAmt);

                //clear input so previous value isn't displayed
                this.input = string.Empty;
            }

            catch (Exception)
            {

                Console.WriteLine("An error occurred");
            }
            
                       
        }

        private void Btn_Backspace_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //remove text from text field

            //check if the input variable is null
            if (input != "")
            {
                //if it isn't remove the last character
                input = input.Remove(input.Length - 1, 1);
            }

            //display what is in input
            this.TxtDollarAmt.Text = input;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {

            this.Hide();

            //show calculator form
            using (var newWindow = new Form1())
            {
                newWindow.Location = this.Location;
                newWindow.ShowDialog();
            }

            //once new form is open, close the old form
            this.Close();
            
        }
    }
}
