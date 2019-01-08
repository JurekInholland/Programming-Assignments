using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Program05
    {
        /// <summary>
        /// Assignment 5 (Console Application)
        /// Enter a year.Show whether that year is a leap year. 
        /// Reject non-positive numbers with an appropriate text.
        /// Keep repeating all of the above steps until 0 is entered as the year.
        /// </summary>
        static void Main(string[] args)
        {
            int stop = 0;

            while (stop != 1)
            {
                // Prompt user to enter a year
                Console.Write("Enter a year: ");
                string input = Console.ReadLine();
                int inputYear = int.Parse(input);

                // Break loop once 0 is entered
                if (input == "0")
                {
                    stop = 1;
                }

                // Notify the user in an appropriate way that the year has to be positive
                if (inputYear < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }

                else
                { 
                    // Determine if entered year is a leap year
                    if (inputYear % 400 == 0 || inputYear % 100 != 0 && inputYear % 4 == 0)
                    {
                            Console.WriteLine(inputYear + " is a leap year.");
                    }

                   else
                    {
                        Console.WriteLine(inputYear + " is not a leap year.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
