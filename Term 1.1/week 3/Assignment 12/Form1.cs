using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_12
{
    public partial class Form1 : Form
    {
        const double PRICE = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string ageStr = txtAge.Text;
            int age = int.Parse(ageStr);
            double multiplier ;

            if (age < 5)
            {
                multiplier = 0;
            }
            else if (age < 13)
            {
                multiplier = 0.5;
            }
            else if (age < 54)
            {
                multiplier = 1;
            }
            else
            {
                multiplier = 0;
            }

            double ticketPrice = PRICE * multiplier;

            lblPrice.Text = string.Format("€ {00:.00}", ticketPrice);

        }
    }
}
