using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string currentSalaryStr = txtCurrentSalary.Text;
            int currentSalary = int.Parse(currentSalaryStr);

            double raise = 0.05 * currentSalary;
            
            if (raise < 75.0)
            {
                raise = 75.0;
            }

            double newSalary = currentSalary + raise;

            string raiseText = string.Format("€ {0:.00}", raise);
            string salaryText = string.Format("€ {0:.00}", newSalary);

            lblRaise.Text = raiseText;
            lblSalary.Text = salaryText;
        }

    }
}
