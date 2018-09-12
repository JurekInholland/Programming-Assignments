using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######################");
            Console.WriteLine("### VAT CALCULATOR ###");
            Console.WriteLine("######################");
            Console.WriteLine();


            while (true){ 

            // Ask the user for input
            Console.Write("Please enter a price.");

            // Read user input from console
            string user_input = Console.ReadLine();

            double price;

            try
            {
                // convert input string to an integer
                price = double.Parse(user_input);

                // calculate VAT (21%)
                double calculated_vat = 0.21 * price;

                // calculate total
                double total_price = price + calculated_vat;

                // output price, vat and total to the user
                Console.WriteLine("price: " + price + ", VAT: " + calculated_vat + ", total: " + total_price);
            }

            catch (FormatException)
            {
                // Notify the user that the input could not be parsed
                Console.WriteLine("Did not receive a valid price.");
            }

            Console.WriteLine();
            }
        }
    }
}
