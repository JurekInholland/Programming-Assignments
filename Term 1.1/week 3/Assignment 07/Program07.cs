using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program07
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight (kg): ");
            string weight = Console.ReadLine();

            Console.Write("Enter length (cm): ");
            string length = Console.ReadLine();

            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            int weightInt = int.Parse(weight);
            double lengthDouble = double.Parse(length);

            // Calculate BMI
            double dividedHeight = lengthDouble / 100;
            double squareHeight = Math.Pow(dividedHeight, 2);
            double bmi = double.Parse(weight) / squareHeight;

            double maleHealthyMin = 20 * squareHeight;
            double maleHealthyMax = 25 * squareHeight;

            Console.WriteLine();
            Console.WriteLine("BMI: {0:.0}", bmi);

            switch (gender)
            {
                case "male":
                    Output(20, 25, squareHeight);
                    break;

                case "female":
                    Output(19, 24, squareHeight);
                    break; 
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Display gender dependent output
        /// </summary>
        public static void Output(int min, int max, double squareHeight)
        {
            Console.WriteLine("normal bmi-values (min .. max): {0}..{1}", min, max);
            Console.WriteLine("healthy weight range: {0:.0} .. {1:.0}", min * squareHeight, max * squareHeight);
            return;
        }
    }
}
