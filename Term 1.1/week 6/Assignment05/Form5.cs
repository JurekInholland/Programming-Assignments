using System;
using System.Windows.Forms;

namespace Assignment05
{
    /// <summary>
    /// Assignment 5 (Windows Application)
    /// Depending on the user's choice, the numbers number1 and number2 are
    /// added up, subtracted, multiplied or divided.
    /// Write a method for each calculation,
    /// clearly name the method to reflect its task.
    /// </summary>
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // Button methods
        private void btnPlus_Click(object sender, EventArgs e)
        {
            (int nr1, int nr2) = ParseFields();
            lblResult.Text = Add(nr1, nr2).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            (int nr1, int nr2) = ParseFields();
            lblResult.Text = Subtract(nr1, nr2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            (int nr1, int nr2) = ParseFields();
            lblResult.Text = Multiply(nr1, nr2).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            (int nr1, int nr2) = ParseFields();
            lblResult.Text = Divide(nr1, nr2).ToString("0.000");
        }

        /// <summary>
        /// Parse text fields and return a tuple of ints
        /// </summary>
        /// <returns></returns>
        private (int nr1, int nr2) ParseFields()
            {
            string text1 = txtNumber1.Text;
            string text2 = txtNumber2.Text;
            return (Convert.ToInt32(text1), Convert.ToInt32(text2));
        }

        // Calculation methods
        static int Add(int nr1, int nr2)
        {
            return nr1 + nr2;
        }

        static int Subtract(int nr1, int nr2)
        {
            return nr1 - nr2;
        }

        static int Multiply(int nr1, int nr2)
        {
            return nr1 * nr2;
        }

        static double Divide(int nr1, int nr2)
        {
            // Avoid integer division by converting both numbers to doubles
            return Convert.ToDouble(nr1) / Convert.ToDouble(nr2);
        }
    }
}
