using System;

namespace Assignment01
{
    class Program01
    {
        /// <summary>
        /// Assignment 1 (Console Application)
        /// Enter a price.Use a separate method to determine the 21% VAT on this price;
        /// this method accepts afloat parameter and returns a float value(‘return value type’ is float).
        /// Print the price, VAT, and the price + VAT.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Parse input
            Console.Write("Enter a price: ");
            double input = Convert.ToDouble(Console.ReadLine());

            // Use the custom method to calculate the VAT
            double vat = CalcVat(input);

            // Output price, VAT and total
            Console.WriteLine("price: {0}, VAT: {1}, total: {2}", input.ToString("0.00"), vat.ToString("0.00"), (input + vat).ToString("0.00"));
            Console.ReadKey();
        }

        /// <summary>
        /// Calculate the 21% VAT. this method accepts a
        /// float parameter and returns a float value
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        static double CalcVat(double price)
        {
            return price * 0.21;
        }
    }
}
