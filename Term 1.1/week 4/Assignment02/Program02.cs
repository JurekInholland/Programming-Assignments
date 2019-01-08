using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program02
    {
        /// <summary>
        /// Assignment 2 (Console Application)
        /// First, a target number is entered and then several numbers.
        /// Determine and print the number of numbers that are equal to the target number.
        /// </summary>
        static void Main(string[] args)
        {
            // Get target number
            Console.Write("Enter target number: ");
            string targetStr = Console.ReadLine();

            int stop = 0;
            int i = 0;

            // Ask for numbers until 0 is entered
            while (stop != 1)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                
                if (userInput == "0")
                {

                    // Notify user about the number of entered target numbers
                    Console.Write("Count of numbers equal to target number: ");
                    Console.WriteLine(i);

                    // Get out of loop
                    stop = 1;
                }

                int inputInt = int.Parse(userInput);

                // Count occurrences of the target number 
                if (inputInt == int.Parse(targetStr))
                {
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
