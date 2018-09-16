using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program08
    {
        const int MAXHOURS = 10000;
        const int MAXYEARS = 7;
        const int MAXFAILURES = 25;

        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours: ");
            string hours = Console.ReadLine();

            Console.Write("Enter number of years: ");
            string years = Console.ReadLine();

            Console.Write("Enter number of failures: ");
            string failures = Console.ReadLine();

            Console.WriteLine();

            int hoursInt = int.Parse(hours);
            int yearsInt = int.Parse(years);
            int failuresInt = int.Parse(failures);

            if (hoursInt > MAXHOURS || yearsInt > MAXYEARS || failuresInt > MAXFAILURES)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }

            else
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }

            Console.ReadKey();
        }
    }
}
