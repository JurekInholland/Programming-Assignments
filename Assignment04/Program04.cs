using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program04
    {
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
        }
    }
}
