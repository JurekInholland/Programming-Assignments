using System;

namespace Assignment03
{
    class Program03
    {
        /// <summary>
        /// Assignment 3 (Console Application)
        /// Several years are entered until number 0 is stated.
        /// Use a separate method 'IsLeapYear' to determine whether each year is a leap year;        /// this method accepts an int parameter and returns a boolean value.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int number = 1;

            // Parse input as long as number is not zero
            while (number != 0)
            {
                Console.Write("Enter a year (0 is stop value): ");
                number = Convert.ToInt32(Console.ReadLine());

                // Check if the isLeapYear method returns true or false with the given input
                if (IsLeapYear(number))
                {
                    Console.WriteLine("{0} is a leap year", number);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", number);
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Check if any given year is a leap year. Returns true/ false
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
