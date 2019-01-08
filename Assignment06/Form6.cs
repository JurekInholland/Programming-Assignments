using System;
using System.Windows.Forms;

namespace Assignment06
{
    /// <summary>
    /// Assignment 6 (Windows Application)
    /// This application is calculating(and displaying) the square of a number entered.
    /// Three methods can be used to calculate squares.
    /// The first method is based on the principle of ‘call by reference’,
    /// the second on ‘call by reference out’ and the third on ‘call by value’. 
    /// </summary>
    public partial class Form6 : Form
    {
        int number;

        public Form6()
        {
            InitializeComponent();
        }

        // Button methods
        private void btnRef_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(txtInput.Text);
            SquareByReference(ref number);
            lblResult.Text = number.ToString();
        }

        private void btnRefOut_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(txtInput.Text);
            SquareByReferenceOut(number, out int square);
            lblResult.Text = square.ToString();
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(txtInput.Text);
            lblResult.Text = SquareByValue(number).ToString();
        }

        // Square methods
        static void SquareByReference(ref int number)
        {
            number = number * number;
        }

        static void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }

        static int SquareByValue(int number)
        {
            return number * number;
        }
    }
}
