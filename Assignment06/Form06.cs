using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment06
{
    public partial class Form06 : Form
    {
        /// <summary>
        /// Assignment 6 (Windows Application)
        /// Calculate 5% yearly interest rate over 5 years
        /// </summary>
        public Form06()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string textInput = txtStart.Text;
            double sum = double.Parse(textInput);

            // Loop once for each year (5)
            for (int i = 0; i < 5; i++)
            {
                // Add 5% interest
                sum += sum * 0.05;
            }
            CultureInfo nl = new CultureInfo("nl-NL");
            // update label in the correct format
            lblFinalCap.Text = sum.ToString("C2", nl);
        }
    }
}
