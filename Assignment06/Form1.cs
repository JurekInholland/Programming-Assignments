using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment06
{
    public partial class Form1 : Form
    {
        int number;

        public Form1()
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
        void SquareByReference(ref int number)
        {
            number = number * number;
        }

        void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }

        int SquareByValue(int number)
        {
            return number * number;
        }
    }
}
