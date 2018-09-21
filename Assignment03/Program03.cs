using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program03
    {
        /// <summary>
        /// Assignment 3 (Console Application)
        /// Several numbers are entered. Determine and print the sum of the 5th,
        /// 10th, 15th number, etc
        /// </summary>
        static void Main(string[] args)
        {
            // Declare and set iterator and sum; make loop exitable
            int i = 0;
            int sum = 0;
            int stop = 0;


            while (stop != 1)
            {
                // Get user input
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();

                // Increase iterator to keep track of the number of entered numbers
                i++;

                // Output sums once 0 is entered
                if (userInput == "0")
                {
                    Console.Write("Sum of 5th, 10th, 15th, ... number is: ");
                    Console.WriteLine(sum);
                    stop = 1;
                }

                int inputInt = int.Parse(userInput);

                // Sum if iterator is diviseable by 5
                if (i % 5 == 0)
                {
                    sum += inputInt;
                }
            }
            Console.ReadKey();
        }
    }
}
