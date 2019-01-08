using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9
{
    public partial class Form1 : Form
    {
        bool isHandball;
        int fee;
        int discount = 0;

       

        public Form1()
        {
            InitializeComponent();
            
        }


        private void rdbFootball_CheckedChanged(object sender, EventArgs e)
        {
            isHandball = false;
        }

        private void rdbHandball_CheckedChanged(object sender, EventArgs e)
        {
            isHandball = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            discount = 0;

            if (isHandball)
            {
                fee = 225;
            }
            else
            {
                fee = 175;
            }

            string duration = txtDuration.Text;
            string age = txtAge.Text;

            int durationInt = int.Parse(duration);
            int ageInt = int.Parse(age);

            if (ageInt > 40)
            {
                discount += 25;
            }

            if (durationInt > 10)
            {
                discount += 20;
            }

            double feeToPay = fee - discount;

            string labelText = string.Format("€{0:.00}", feeToPay);

            lblFee.Text = labelText;
        }
    }
}
