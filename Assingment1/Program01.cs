using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    

    class Program01
    {
        

        static void Main(string[] args)
        {
            int stop = 0;
            int i = 0;
            int sum = 0;

            while (stop != 1)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                double result = 0;
                if (userInput == "0")
                {
                    if (i != 0)
                    {
                        result = Convert.ToDouble(sum) / Convert.ToDouble(i);

                    }
                    
                    Console.Write("Average of all positive numbers is: ");
                    Console.WriteLine(result.ToString("0.00"));
                    stop = 1;
                }

                int inputInt = int.Parse(userInput);
                if (inputInt >= 0)
                {
                    i++;
                    sum += inputInt;
                }   
            }
            Console.ReadKey();
        }
    }
}
