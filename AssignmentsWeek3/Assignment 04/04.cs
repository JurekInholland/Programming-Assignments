using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
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

            int sum = firstInt + secondInt + thirdInt;

            double avg =  Convert.ToDouble(sum) / 3;

            int prod = firstInt * secondInt * thirdInt;

            int highest = Max(firstInt, secondInt, thirdInt);

            int lowest = Min(firstInt, secondInt, thirdInt);

            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("average = {0:.00}", avg);
            Console.WriteLine("product = {0}", prod);
            Console.WriteLine("highest = {0}", highest);
            Console.WriteLine("lowest = {0}", lowest);

            Console.ReadKey();
        }
        /// <summary>
        /// Get the highest of three values.
        /// </summary>
        public static int Max(int x, int y, int z)
        {
            return Math.Max(x, Math.Max(y, z));
        }

        /// <summary>
        /// Get the lowest of three values.
        /// </summary>
        public static int Min(int x, int y, int z)
        {
            return Math.Min(x, Math.Min(y, z));
        }
    }
}
 