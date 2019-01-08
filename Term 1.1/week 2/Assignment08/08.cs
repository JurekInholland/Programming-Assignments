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
    public partial class Form1 : Form
    {
        // define constants
        const int JEANSPRICE = 100;
        const int SHIRTPRICE = 30;
        const double VAT = 0.21;
        const string CURRENCY = "€ ";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_click(object sender, EventArgs e)
        {
            string numberShirts = txtShirts.Text;
            string numberJeans = txtJeans.Text;

            //DateTime dateTime = DateTime.UtcNow.Date;
            string dateString = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");

            try
            {
                int shirts = int.Parse(numberShirts);
                int jeans = int.Parse(numberJeans);

                int shirtCost = shirts * SHIRTPRICE;
                int jeansCost = jeans * JEANSPRICE;

                int totalCost = shirtCost + jeansCost;

                double totalVat = totalCost * VAT;

                double totalPrice = totalCost + totalVat;

                lblDate.Text = dateString;
                lblPrice.Text = totalCost.ToString("€ 0.00");
                lblTotal.Text = totalPrice.ToString("€ 0.00");
                lblVat.Text = totalVat.ToString("€ 0.00");

            }
            catch (FormatException)
            {
                lblDate.Text = "";
                lblPrice.Text = "";
                lblTotal.Text = "";
                lblVat.Text = "";
            }







        }
    }
}
