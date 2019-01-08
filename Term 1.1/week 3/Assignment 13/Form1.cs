using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_13
{
    public partial class assignment13 : Form
    {
        const int DAILYRATE = 55;
        const double PRICEPERKM = 0.25;
        const double PRICELITERFUEL = 2.2;
        

        public assignment13()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            string daysStr = txtDays.Text;
            string kmsStr = txtKms.Text;
            string litresStr = txtLitres.Text;

            int daysRented = int.Parse(daysStr);
            int kmsDriven = int.Parse(kmsStr);
            int litresTanked = int.Parse(litresStr);

            bool checkState = cbRefuel.Checked;

            

            totalPrice += daysRented * DAILYRATE;

            if (kmsDriven > 100 * daysRented)
            {
                totalPrice += (kmsDriven - 100 * daysRented) * PRICEPERKM;
            }
            
            if (checkState)
            {
                totalPrice += (litresTanked * PRICELITERFUEL);
            }

            lblRentalPrice.Text = totalPrice.ToString("€ 0.00");
        }
    }
}
