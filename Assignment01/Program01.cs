using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    /// <summary>
    /// Assignment 1 (Console Application)
    /// The computer inserts 20 random numbers(with values between 0 and 200) in an array of 20
    /// elements.After the array has been completely filled, all elements are shown and the average of the
    /// numbers in the array is determined and shown.Lastly, the difference between the numbers in the
    /// array with the average is shown.
    /// </summary>
    class Program01
    {
        // Define how many random numbers should be generated and processed
        const int NUMBERS = 20;

        static void Main(string[] args)
        {
            // Initialize an int array with 20 elements
            var numbersArray = new int[NUMBERS];

            // random number generator
            Random rnd = new Random();

            int total = 0;
            int randomNr = 0;

            // Loop through array elements
            for (int i = 0; i < NUMBERS; i++ )
            {
                // Generate a random number betwen 0 and 200
                randomNr = rnd.Next(0, 201);
                
                // Assign the random number to the current array element
                numbersArray[i] = randomNr;

                // sum up the total
                total += randomNr;

                //print the array element to the user
                Console.WriteLine("Element {0} is {1}", i.ToString(), numbersArray[i].ToString());
            }

            // Calculate the average
            double average = Convert.ToDouble(total) / NUMBERS;


            // Output the average to the user
            Console.WriteLine();

            Console.WriteLine("The average is {0}", average.ToString("0.00"));

            Console.WriteLine();

            string difference;

            // Loop again to compare averages
            for (int i = 0; i < NUMBERS; i++)
            {
                // Calculate the difference between the average and the given array element
                difference = MakeAbsolute(average - numbersArray[i]);

                // Output differences to the user
                Console.WriteLine("Difference between average and element {0} is {1}", i.ToString(), difference);

            }

            // Keep the application running
            Console.ReadKey();
        }

        /// <summary>
        /// Manually make a double absolute by multiplying it by -1 if it's negative.
        /// Afterwards, convert it to a string and return it.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static string MakeAbsolute(double input)
        {
            if (input < 0)
            {
                input = input * (-1);
            }
            return input.ToString("0.00");
        }
    }
}
