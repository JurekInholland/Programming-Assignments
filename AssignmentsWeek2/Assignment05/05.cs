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

            string user_input = txtNr1.Text;

            // prompt user for input
            Console.WriteLine("Enter number of seconds: ");
            string number1 = txtNr1.Text;
            string number2 = txtNr2.Text;
            string number3 = txtNr3.Text;

            double parsed1, parsed2, parsed3;

            try
            {
                parsed1 = double.Parse(number1);
                parsed2 = double.Parse(number2);
                parsed3 = double.Parse(number3);

                double sum_numbers = parsed1 + parsed2 + parsed3;
                double average = sum_numbers / 3;

                lblAverage.Text = average.ToString("0.000");

            }

            catch (FormatException)
            {
                lblAverage.Text = "Please enter valid numbers.";
            }

        }

       
    }
}
