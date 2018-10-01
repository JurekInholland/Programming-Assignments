using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment06
{
    public partial class Form06 : Form
    {
        // Define the desired number of array elements
        const int ARRAYSIZE = 20;

        // Initialize an array of ints of the specified size
        int[] randomArray = new int[ARRAYSIZE];

        public Form06()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generate an array of random numbers once the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Random number generator
            Random rnd = new Random();

            // Fill the first array with random numbers between 0 and 500
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                // Generate a random number between 0 and 500
                int randomNr = rnd.Next(0, 501);
                randomArray[i] = randomNr;
            }

            // Update the text label
            lblContentBefore.Text = ArrayToString(randomArray);
        }

        /// <summary>
        /// On button press, compare the generated array to an user input number, display a second updated array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompare_Click(object sender, EventArgs e)
        {
            // Parse the coparison number
            int[] newArray = new int[ARRAYSIZE];
            int comparisonNr = Convert.ToInt32(txtComparison.Text);

            // Compare each array element to the comparison number; Store modified result in new array
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                // Modify the array elements dependant on the result of the comparison
                if (randomArray[i] >= comparisonNr)
                {
                    newArray[i] = randomArray[i] + 10;
                }
                else
                {
                    newArray[i] = randomArray[i] - 5;
                }
            }

            // Update the other text label
            lblContentAfter.Text = ArrayToString(newArray);
        }

        /// <summary>
        /// Takes an array and returns a formatted string of array elements
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static string ArrayToString(int[] array)
        {
            string output = "";

            // Loop through all array elements
            for (int i = 0; i < array.Length; i++)
            {
                // Format each line correctly
                string labelString = string.Format("Element {0} = {1}\n", i.ToString("D2"), array[i]);
                output += labelString;
            }
            // Return a string consisting of all array elements
            return output;
        }
    }
}
