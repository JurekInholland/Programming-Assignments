using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                Console.WriteLine("Please enter three numbers:");

                Console.Write("1st number:");
                string number1 = Console.ReadLine();

                Console.Write("2nd number:");
                string number2 = Console.ReadLine();

                Console.Write("3rd number:");
                string number3 = Console.ReadLine();

                double parsed1, parsed2, parsed3;

                try
                {
                    parsed1 = double.Parse(number1);
                    parsed2 = double.Parse(number2);
                    parsed3 = double.Parse(number3);

                    double sum_numbers = parsed1 + parsed2 + parsed3;
                    double average = sum_numbers / 3;

                    Console.WriteLine("The average is " + average);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid numbers next time.");
                }


                Console.WriteLine();
            }
        }
    }
}
