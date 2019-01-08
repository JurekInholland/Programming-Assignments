using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Enter second number: ");
            string secondNumber = Console.ReadLine();

            Console.Write("Enter third number: ");
            string thirdNumber = Console.ReadLine();

            int firstInt = int.Parse(firstNumber);
            int secondInt = int.Parse(secondNumber);
            int thirdInt = int.Parse(thirdNumber);

            if (firstInt > thirdInt && secondInt > thirdInt)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }

            Console.ReadKey();
        }
    }
}
