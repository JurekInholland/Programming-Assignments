﻿using System;

namespace Assignment02
{
    
    class Program02
    {
        /// <summary>
        /// Assignment 2 (Console Application)
        /// Several numbers are entered until number 0 is stated.
        /// Use a separate method 'IsPrimeNumber' to determine
        /// whether the positive numbers(>0) are prime numbers;
        /// this method accepts an intparameter and returns a boolean value.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int number = 1;

            // Parse input as long as number is not zero
            while (number != 0)
            {
                Console.Write("Enter a number (0 is stop value): ");
                number = Convert.ToInt32(Console.ReadLine());

                // Do not check negative numbers
                if (number < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                // Check positive non-zero numbers for primeness using the primeCheck method
                else if (number != 0)
                {
                    // Print output depending on result
                    if (IsPrime(number))
                    {
                        Console.WriteLine("{0} is a prime number", number);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a prime number", number);
                    }
                }
                // Do nothing if zero is entered
                else
                {
                    Console.WriteLine("end of program");
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Check if a given integer is a prime number; return true/false
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool IsPrime(int input)
        {
            if (input == 0 || input == 1)
            {
                return false;
            }
            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
