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
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_vat_Click(object sender, EventArgs e)
        {

            string user_input = txtInput.Text;

            double price;

            try
            {
                // convert input string to an integer
                price = double.Parse(user_input);

                // calculate VAT (21%)
                double calculated_vat = 0.21 * price;

                // calculate total
                double total_price = price + calculated_vat;

                // output price, vat and total to the user
                lblTotal.Text = total_price.ToString("0.00");
                lblVat.Text = calculated_vat.ToString("0.00");
                lblPrice.Text = price.ToString("0.00");

            }

            catch (FormatException)
            {
                // Notify the user that the input could not be parsed
                lblTotal.Text = "0";
                lblVat.Text = "0";
                lblPrice.Text = "0";
            }
        }
    }
}
