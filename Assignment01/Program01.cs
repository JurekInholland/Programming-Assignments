using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program01
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a price: ");
            double input = Convert.ToDouble(Console.ReadLine());

            double vat = CalcVat(input);
            Console.WriteLine("price: {0}, VAT: {1}, total: {2}", input.ToString("0.00"), vat.ToString("0.00"), (input + vat).ToString("0.00"));
            Console.ReadKey();
        }

        static double CalcVat(double price)
        {
            return price * 0.21;
        }
    }
}
