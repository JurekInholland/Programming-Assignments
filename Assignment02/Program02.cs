using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    
    class Program02
    {
        
        static void Main(string[] args)
        {
            int number = 1;
            while (number != 0)
            {
                Console.Write("Enter a number (0 is stop value): ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else
                {
                    bool primeCheck = IsPrime(number);
                    if (primeCheck == true)
                    {
                        Console.WriteLine("{0} is a prime number", number);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a prime number", number);
                    }
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
