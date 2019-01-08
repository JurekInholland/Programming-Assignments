using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1..4):");
            string input = Console.ReadLine();

            if (input == "1" || input == "2" || input == "3" || input == "4")
            {
                int inputParsed = int.Parse(input);
                switch (inputParsed)
                {
                    case 1:
                        Console.WriteLine("clubs");
                        break;

                    case 2:
                        Console.WriteLine("diamonds");
                        break;

                    case 3:
                        Console.WriteLine("hearts");
                        break;

                    case 4:
                        Console.WriteLine("spades");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Incorrect number!");
            }
            Console.ReadKey();
        }
    }
}
