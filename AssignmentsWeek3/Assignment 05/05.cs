using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
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

            if (firstInt % secondInt == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }

            else if (secondInt % firstInt == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }

            else
            {
                Console.WriteLine("Numbers are no multiples");
            }

            Console.ReadKey();
        }
    }
}
