using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment07
{
    public partial class Form1 : Form
    {
        int radio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Track which radio button is currently selected
        private void rdbCelsiusToKelvin_CheckedChanged(object sender, EventArgs e)
        {
            radio = 0;
        }

        private void rdbCelsiusToFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            radio = 1;
        }

        private void rdbFahrenheitToCelsius_CheckedChanged(object sender, EventArgs e)
        {
            radio = 2;
        }

        // Do the correct conversion depending on the selected radio button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            double result = 0;

            switch (radio)
            {
                case 0:
                    result = Celsius2Kelvin(input);
                    break;
                case 1:
                    result = Celsius2Fahrenheit(input);
                    break;
                case 2:
                    result = Fahrenheit2Celsius(input);
                    break;
            }

            // Display the result in a text label
            lblResult.Text = result.ToString("0.00");
        }

        // Conversion methods
        int Celsius2Kelvin(int c)
        {
            return c + 273;
        }

        double Celsius2Fahrenheit(int c)
        {
            return Convert.ToDouble(c) * 9 / 5 + 32;
        }

        double Fahrenheit2Celsius(int f)
        {
            return (Convert.ToDouble(f) - 32) * 5 / 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
