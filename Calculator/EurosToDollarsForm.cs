using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "0";  //add 0 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_One_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "1";  //add 1 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_Two_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "2";  //add 2 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_Three_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "3";  //add 3 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_Four_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "4";  //add 4 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_Five_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "5";  //add 5 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_Six_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "6";  //add 6 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_Seven_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "7";  //add 7 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_Eight_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "8";  //add 8 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
        }

        private void Btn_Nine_Click(object sender, EventArgs e)
        {
            this.TxtDollarAmt.Text = ""; //clear text box of current value
            input += "9";  //add 9 to existing value entered by user
            this.TxtDollarAmt.Text += input; //adds new value to text field to display to user
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
                this.TxtDollarAmt.Text = ""; //clear text box
                input += ".";  //add . to existing value entered by user
                this.TxtDollarAmt.Text += input; //adds value to text field to display to user
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
            //get amounts from website
            WebRequest request = WebRequest.Create("http://free.currencyconverterapi.com/api/v5/convert?q=USD_EUR&compact=y");
            //save response
            WebResponse response = request.GetResponse();
            //put response into usable format
            Stream dataStream = response.GetResponseStream();
            //variable for method
            string dataAmt = "";
            //pull all data out of response from website
            using (StreamReader responseReader = new StreamReader(dataStream))
            {
                //read the data
                string json = responseReader.ReadToEnd();
                //look for dollar to euro amount
                string data = JObject.Parse(json)["USD_EUR"].ToString();
                //save value from webiste to use in calculation
                dataAmt = JObject.Parse(data)["val"].ToString();

            }

            //convert the amount returned into a number
            double conversionAmt = Convert.ToDouble(dataAmt);
            //convert user provided amount into a number
            double dollarAmt = Convert.ToDouble(input);
            //convert from euro to dollar
            double euroAmt = conversionAmt * dollarAmt;
            //display to user
            this.TxtEuroAmt.Text = Convert.ToString(euroAmt);
                       
        }

        private void Btn_Backspace_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            var newWindow = new Form1();
            newWindow.Location = this.Location;
            this.Hide();
            newWindow.Show();
        }
    }
}
