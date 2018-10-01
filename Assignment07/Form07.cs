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
        // Define how many dice should be thrown
        const int THROWS = 6000;

        // random number generator
        Random rnd = new Random();

        public Form07()
        {
            InitializeComponent();
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            // Initialize and array of ints with 6 elements
            int[] diceArray = new int[6];

            // Fill the array with zeroes
            for (int i = 0; i < 6; i++)
            {
                diceArray[i] = 0;
            }

            // Roll die THROWS amount of times
            for (int i = 0; i < THROWS; i++)
            {
                // Generate a random number between 1 and 6
                int randomNr = rnd.Next(1, 7);

                // Count occurences of each number
                diceArray[randomNr - 1]++;
            }

            // Convert array to string and update text label
            lblThrows.Text = DiceArrayToString(diceArray);
        }

        /// <summary>
        /// Takes an array of results of dice throws and returns a formatted string of said results 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static string DiceArrayToString(int[] array)
        {
            string output = "";

            // Loop through all array elements
            for (int i = 0; i < array.Length; i++)
            {
                // Format each line correctly
                string labelString = string.Format("Number of throws of value {0} = {1}\n", i + 1, array[i]);
                output += labelString;
            }
            // Return a string consisting of all array elements
            return output;
        }
    }


}
