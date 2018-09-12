using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_vat_Click(object sender, EventArgs e)
        {

            string user_input = txtInput.Text;

            // prompt user for input
            Console.WriteLine("Enter number of seconds: ");
            string input = txtInput.Text;

            // try to parse user input as an integer
            try
            {
                int number = int.Parse(input);

                // calculate hours minutes and seconds
                int hours = number / 3600;
                int minutes = (number - hours * 3600) / 60;
                int seconds = (number - hours * 3600) - minutes * 60;

                // convert to right string format ("D2" adds a padding zero)
                string hours_str = hours.ToString("D2");
                string minutes_str = minutes.ToString("D2");
                string seconds_str = seconds.ToString("D2");

                // update label text to display the formatted time
                lblTime.Text = hours_str + ":" + minutes_str + ":" + seconds_str;

            }
            // catch the exception
            catch (FormatException)
            {
                lblTime.Text = "Please enter a valid integer";
            }
        }
    }
}
