using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_14
{
    public partial class A14 : Form
    {
        public A14()
        {
            InitializeComponent();
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            ButtonPress("male");
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            ButtonPress("female");
        }

        /// <summary>
        /// Calculate BMI, normal and healthy ranges and update labels
        /// </summary>
        /// <param name="gender"></param>
        private void ButtonPress(string gender)
        {
            (double height, double weight) = UserInput(txtLength.Text, txtWeight.Text);
            (double bmi, double squareHeight) = CalcBmi(height, weight);
            (int normMin, int normMax) = GenderCalc(gender);

            (double healthyMin, double healthyMax) = HealthyRange(normMin, normMax, squareHeight);

            lblBmi.Text = bmi.ToString("0.0");
            lblNormalBmi.Text = string.Format("{0} .. {1}", normMin, normMax);
            lblHealthyWeight.Text = string.Format("{0:.0} .. {1:.0}", healthyMin, healthyMax);
        }



        /// <summary>
        /// Calculate the BMI
        /// </summary>
        private static (double, double) CalcBmi(double height, double weight)
        {
            double squareHeight = Math.Pow(height / 100, 2);
            double bmi = weight / squareHeight;
            return (bmi, squareHeight);
            
        }

        /// <summary>
        /// Return normal BMI values for each gender
        /// </summary>
        private static (int, int) GenderCalc(string gender)
        {
            if (gender == "male")
            {
                return (20, 25);
            }
            else if (gender == "female")
            {
                return (19, 24);
            }
            return (1, 1);
        }

        /// <summary>
        /// Sanitize user input
        /// </summary>
        private static (double, double) UserInput(string lengthStr, string weightStr)
        {
            // ~ Error checking would go here ~
  
             
            return (double.Parse(lengthStr), double.Parse(weightStr));
        }

        /// <summary>
        /// calculate healthy weight range
        /// </summary>
        private static (double, double) HealthyRange(double min, double max, double squareHeight)
        {
            return (min * squareHeight, max * squareHeight);
        }
    }

}
