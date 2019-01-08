using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        const double VAT = 0.21;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnErase_Click(object sender, EventArgs e)
        {
            // Clear text boxes and labels
            txtEndkm.Text = "";
            txtStartkm.Text = "";
            txtPricekm.Text = "";

            lblPrice.Text = "";
            lblVAT.Text = "";
            lblTotal.Text = "";
            // test
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // cast user input to strings
            string start_km = txtStartkm.Text;
            string end_km = txtEndkm.Text;
            string price_per_km = txtPricekm.Text;

            
            // catch format exceptions
            try
            {
                // parse user input as doubles
                double parsedStart = double.Parse(start_km);
                double parsedEnd = double.Parse(end_km);
                double parsedPricePer = double.Parse(price_per_km);


                // calculate distance, cost, VAT and total cost
                double distance_traveled = parsedEnd - parsedStart;

                double travel_cost = distance_traveled * parsedPricePer;

                double vat = travel_cost * VAT;

                double total_cost = travel_cost + vat;
                

                // Update labels in the correct format
                lblPrice.Text = travel_cost.ToString("0.00");

                lblVAT.Text = vat.ToString("0.00");

                lblTotal.Text = total_cost.ToString("0.00");


            }

            // handle exception
            catch (FormatException)
            {
                lblPrice.Text = "Please enter valid numbers.";
            }
        }
    }
}
