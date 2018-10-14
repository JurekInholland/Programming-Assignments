using System;
using System.Windows.Forms;

namespace Assignment05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            (int nr1, int nr2) = ParseFields();
            lblResult.Text = Add(nr1, nr2).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            (int nr1, int nr2) = ParseFields();
            lblResult.Text = Subtract(nr1, nr2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            (int nr1, int nr2) = ParseFields();
            lblResult.Text = Multiply(nr1, nr2).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            (int nr1, int nr2) = ParseFields();
            lblResult.Text = Divide(nr1, nr2).ToString("0.000");
        }

        private (int nr1, int nr2) ParseFields()
            {
            string text1 = txtNumber1.Text;
            string text2 = txtNumber2.Text;
            return (Convert.ToInt32(text1), Convert.ToInt32(text2));
        }

        static int Add(int nr1, int nr2)
        {
            return nr1 + nr2;
        }

        static int Subtract(int nr1, int nr2)
        {
            return nr1 - nr2;
        }

        static int Multiply(int nr1, int nr2)
        {
            return nr1 * nr2;
        }

        static double Divide(int nr1, int nr2)
        {
            return Convert.ToDouble(nr1) / Convert.ToDouble(nr2);
        }
    }
}
