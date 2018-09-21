using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment07
{
    public partial class Form07 : Form
    {
        /// <summary>
        /// Assignment 7 (Windows Application)
        /// Draw the following pattern, a square border with side n.
        /// For example, n = 5 produces the following result:        ///         /// XXXXX        /// X   X        /// X   X        /// X   X        /// XXXXX
        /// </summary>
        public Form07()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sidesStr = txtSides.Text;
            int sides = int.Parse(sidesStr);
            string output = "";

            // Loop once for each number of sides
            for (int i = 0; i < sides; i++)
            {
                // If its the first or last line
                if (i == 0 || i == sides - 1)
                {
                    // Draw Xs equal to the number of sides
                    for (int j = 0; j < sides; j++)
                    {
                        output += "X";
                    }
                    // new line when done
                    output += "\n";
                }

                // Draw all lines in between
                else
                {
                    // Draw an X in the beginning
                    output += "X";

                    // Fill rest with spaces
                    for (int j = 0; j < sides - 2; j++)
                    {
                        output += " ";
                    }
                    // Draw an X again and add a new line
                    output += "X\n";
                }
                
            }
            // Display the pattern in the label
            lblRender.Text = output;
        }
    }
}
