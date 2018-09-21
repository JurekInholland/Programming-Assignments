using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program04
    {
        /// <summary>
        /// Assignment 4 (Console Application)
        /// Determine the first 20 numbers in the (Fibonacci) series: 1 1 2 3 5 8 13 ...
        /// </summary>
        static void Main(string[] args)
        {
            const int NBRS = 20;
            string seperator = ", ";

            // Initialize an empty array that has the correct size
            int[] fibonacciNumbers = new int[NBRS];

            for (int i = 0; i < NBRS; i++)
            {

                if (i > 1)
                {
                    // Create sum ov previous two array elements
                    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                }

                // Handle number 1 and 2, which are both 1 seperately
                else
                {
                    fibonacciNumbers[i] = 1;
                }

                // Don't add a comma after the last number
                if (i == NBRS - 1)
                {
                    seperator = "";
                }

                // Output fibonacci number and seperator
                Console.Write(fibonacciNumbers[i] + seperator);
                
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
