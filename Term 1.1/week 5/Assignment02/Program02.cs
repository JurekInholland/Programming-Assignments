using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program02
    {
<<<<<<< HEAD
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
=======
        // Define how many random numbers should be generated and processed
        const int NUMBERS = 20;

        static void Main(string[] args)
        {
            // Initialize an array of ints with 20 elements
            var numbersArray = new int[NUMBERS];

            // random number generator
            Random rnd = new Random();

            // Loop through array elements
            for (int i = 0; i < NUMBERS; i++)
            {
                // Generate a random number betwen 0 and 200
                int randomNr = rnd.Next(0, 201);

                // Assign the random number to the current array element
                numbersArray[i] = randomNr;

                //print each array element to the user
                Console.WriteLine("Element {0} = {1}", i.ToString(), numbersArray[i].ToString());
            }

            int smallest = numbersArray[0];

            // Loop through the generated numbers to determine the smallest one
            for (int i = 0; i < NUMBERS; i++)
            {
                int number = numbersArray[i];
                if (number < smallest)
                {
                    smallest = number;
                }
            }

            int count = 0;

            // Loop a final time to count the occurences.
            for (int i = 0; i < NUMBERS; i++)
            {
                if (numbersArray[i] == smallest)
                {
                    count++;
                }
            }

            // Output results to the user
            Console.WriteLine();
            Console.WriteLine("smallest number = {0}", smallest);
            Console.WriteLine("number of occurence = {0}", count.ToString());
>>>>>>> programming-week5/master
            Console.ReadKey();
        }
    }
}
