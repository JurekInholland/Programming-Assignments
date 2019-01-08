using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
<<<<<<< HEAD

    class Program01
    {

        /// <summary>
        /// Assignment 1 (Console Application)
        /// Several numbers are entered until number 0 is stated.
        /// Calculate and print the average of the positive numbers.
        /// </summary>
        static void Main(string[] args)
        {
            // Use a dot as decimal seperator unaffected by os locale settings
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // Declare and set iterator and sum; make loop exitable
            int i = 0;
            int sum = 0;
            int stop = 0;
            
            while (stop == 0)
            {
                // Parse user input
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                int inputInt = int.Parse(userInput);

                double result = 0;

                // Calculate result once 0 is entered
                if (userInput == "0")
                {
                    // Calculate average of positive inputs
                    if (i != 0)
                    {
                        result = Convert.ToDouble(sum) / Convert.ToDouble(i);
                    }

                    // Output result
                    Console.Write("Average of all positive numbers is: ");
                    Console.WriteLine(result.ToString("0.00"));

                    // Get out of loop
                    stop = 1;
                }

                // Sum up positive inputs
                if (inputInt > 0)
                {
                    i++;
                    sum += inputInt;
                }
            }
            Console.ReadKey();
        }
=======
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
>>>>>>> programming-week5/master
    }
}
