using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment08
{
    public partial class Form08 : Form
    {
        /// <summary>
        /// Assignment 8 (Windows Application)
        /// Determine the following: sum = 0 + 1 + 2 + .... + n.
        /// Check the result using the formula: sum = n × (n + 1) / 2.
        /// State whether or not these sums are equal to each other.
        /// </summary>
        public Form08()
        {
            InitializeComponent();
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            // Parse text field as int
            string numberStr = txtNumber.Text;
            long number = long.Parse(numberStr);

            // calculate the sum iteratively
            long sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            
            // calculate the sum using the formula
            long formulaSum = number * (number + 1) / 2;

            // Update text labels to display the calculated sums
            lblSum.Text = sum.ToString();
            lblFormula.Text = formulaSum.ToString();

            // Verify both sums are equal
            if (sum == formulaSum)
            {
                lblEqualCheck.Text = "The sum and formula are equal.";
            }
            else
            {
                lblEqualCheck.Text = "The sum and forula are NOT equal!";
            }
        }
    }
}
