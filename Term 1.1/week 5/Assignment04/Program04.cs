using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program04
    {
<<<<<<< HEAD
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
                    // Create sum of previous two array elements
                    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                }

                // Handle number 1 and 2, which are both 1, seperately
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
=======
        static void Main(string[] args)
        {
            int lastNumber = 1;
            int index = 0;
            int occurences = 0;

            // Init and array of ints of the size 20
            var numbersArray = new int[20];


            while (lastNumber != 0)
            {
                Console.Write("Enter a number (0=stop): ");
                lastNumber = Convert.ToInt32(Console.ReadLine());

                // If array is not already full, store non-zero value and move index forward
                if (lastNumber != 0 && index < 20)
                {
                    numbersArray[index] = lastNumber;
                    index++;
                }
                // If zero was entered, ask user to input searchvalue
                else if (lastNumber == 0)
                {
                    Console.WriteLine();
                    Console.Write("Enter a searchvalue: ");
                    int searchValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    
                    // Count the occurences of searchvalue in the array
                    for (int i = 0; i < index; i++)
                    {
                        if (searchValue == numbersArray[i])
                        {
                            occurences++;
                        }
                    }

                    // Output the number of occurences
                    Console.WriteLine("Number of occurences of searchvalue ({0}) is: {1}", searchValue, occurences);
                }
            }
            Console.ReadKey();
>>>>>>> programming-week5/master
        }
    }
}
