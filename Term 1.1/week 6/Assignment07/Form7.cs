using System;
using System.Windows.Forms;

namespace Assignment07
{
    /// <summary>
    /// Assignment 7 (Windows Application)
    /// A Windows Forms application must be designed and implemented to convert temperatures.
    /// If, for example, a temperature is entered in degrees Celsius,
    /// it can be converted to Kelvin or degrees Fahrenheit or vice versa
    /// by selecting a radiobutton and clicking the Calculate button.

    /// </summary>
    public partial class Form7 : Form
    {
        int radio = 0;

        public Form7()
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
        static int Celsius2Kelvin(int c)
        {
            return c + 273;
        }

        static double Celsius2Fahrenheit(int c)
        {
            return Convert.ToDouble(c) * 9 / 5 + 32;
        }

        static double Fahrenheit2Celsius(int f)
        {
            return (Convert.ToDouble(f) - 32) * 5 / 9;
        }
    }
}
