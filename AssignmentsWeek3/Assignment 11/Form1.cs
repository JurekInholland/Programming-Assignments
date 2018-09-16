using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nr1String = txtNr1.Text;
            string nr2String = txtNr2.Text;

            double nr1 = double.Parse(nr1String);
            double nr2 = double.Parse(nr2String);

            double highest = Math.Max(nr1, nr2);
            double average = (nr1 + nr2) / 2;

            double difference = Math.Abs(highest - average);

            lblNumber.Text = highest.ToString();
            lblAverage.Text = average.ToString();
            lblDifference.Text = difference.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
