using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // prompt user for input
                Console.WriteLine("Enter number of seconds: ");
                string input = Console.ReadLine();

                // try to parse user input as an integer
                try
                {
                    int number = int.Parse(input);

                    // calculate hours minutes and seconds
                    int hours = number / 3600;
                    int minutes = (number - hours * 3600) / 60;
                    int seconds = (number - hours * 3600) - minutes * 60;

                    // convert to right string format ("D2" adds a padding zero)
                    string hours_str = hours.ToString("D2");
                    string minutes_str = minutes.ToString("D2");
                    string seconds_str = seconds.ToString("D2");

                    // output formatted time
                    Console.WriteLine(hours_str + ":" + minutes_str + ":" + seconds_str);

                }
                // catch the exception
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer.");
                }

                Console.WriteLine();
            }
        }
    }
}
