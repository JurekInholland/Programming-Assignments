using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Enter second number: ");
            string secondNumber = Console.ReadLine();

            int firstInt = int.Parse(firstNumber);
            int secondInt = int.Parse(secondNumber);

            if (firstInt > secondInt)
            {
                Console.WriteLine("Highest number is {0}:", firstInt);
                Console.WriteLine("Lowest number is {0}:", secondInt);
            }
            else
            {
                Console.WriteLine("Highest number is {0}:", secondInt);
                Console.WriteLine("Lowest number is {0}:", firstInt);
            }

            Console.ReadKey();
        }
    }
}
