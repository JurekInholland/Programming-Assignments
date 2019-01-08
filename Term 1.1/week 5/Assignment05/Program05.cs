using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Program05
    {
<<<<<<< HEAD
        /// <summary>
        /// Assignment 5 (Console Application)
        /// Enter a year.Show whether that year is a leap year. 
        /// Reject non-positive numbers with an appropriate text.
        /// Keep repeating all of the above steps until 0 is entered as the year.
        /// </summary>
        static void Main(string[] args)
        {
            int stop = 0;

            while (stop != 1)
            {
                // Prompt user to enter a year
                Console.Write("Enter a year: ");
                string input = Console.ReadLine();
                int inputYear = int.Parse(input);

                // Break loop once 0 is entered
                if (input == "0")
                {
                    stop = 1;
                }

                // Notify the user in an appropriate way that the year has to be positive
                if (inputYear < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }

                else
                { 
                    // Determine if entered year is a leap year
                    if (inputYear % 400 == 0 || inputYear % 100 != 0 && inputYear % 4 == 0)
                    {
                            Console.WriteLine(inputYear + " is a leap year.");
                    }

                   else
                    {
                        Console.WriteLine(inputYear + " is not a leap year.");
                    }
                }
            }
=======
        static void Main(string[] args)
        {
            // Use a dot as decimal seperator unaffected by os locale settings
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // Initialize lots of variables
            int lastNumber = 1;

            int preSchoolIndex = 0;
            int preSchoolSum = 0;
            int oldestPreschooler = 0;

            int childrenIndex = 0;
            int childrenSum = 0;
            int oldestChild = 0;

            int adultIndex = 0;
            int adultSum = 0;
            int oldestAdult = 0;

            double average = 0;

            var preschoolers = new int[10];
            var children = new int[10];
            var adults = new int[10];

            while (lastNumber != 0)
            {
                Console.Write("Enter age (0=stop): ");
                lastNumber = Convert.ToInt32(Console.ReadLine());

                // filter preschoolers
                if (lastNumber > 0 && lastNumber <= 3)
                {
                    preschoolers[preSchoolIndex] = lastNumber;
                    preSchoolIndex++;
                    
                    // Sum up age and keep track of the oldest
                    preSchoolSum += lastNumber;
                    if (lastNumber > oldestPreschooler)
                    {
                        oldestPreschooler = lastNumber;
                    }
                }
                // filter children
                else if (lastNumber > 0 && lastNumber <= 17)
                {
                    children[childrenIndex] = lastNumber;
                    childrenIndex++;
                    
                    // Sum up age and keep track of the oldest
                    childrenSum += lastNumber;
                    if (lastNumber > oldestChild)
                    {
                        oldestChild = lastNumber;
                    }
                }
                // filter adults
                else if (lastNumber > 17)
                {
                    adults[adultIndex] = lastNumber;
                    adultIndex++;
                    
                    // Sum up age and keep track of the oldest
                    adultSum += lastNumber;
                    if (lastNumber > oldestAdult)
                    {
                        oldestAdult = lastNumber;
                    }
                }
            }
            // Write detailed output

            // PRESCHOOLERS
            Console.WriteLine();
            Console.WriteLine("PRESCHOOLERS");
            for (int i = 0; i < preSchoolIndex; i++)
            {
                Console.WriteLine("Preschooler {0} is {1} years old.", i + 1, preschoolers[i]);
            }
            average = Convert.ToDouble(preSchoolSum) / preSchoolIndex;
            Console.WriteLine("Average preschooler is {0} years old", average.ToString("0.00"));
            Console.WriteLine("Oldest preschooler is: {0}", oldestPreschooler);


            // CHILDREN
            Console.WriteLine();
            Console.WriteLine("CHILDREN");
            for (int i = 0; i < childrenIndex; i++)
            {
                Console.WriteLine("Child {0} is {1} years old.", i + 1, children[i]);
            }
            average = Convert.ToDouble(childrenSum) / childrenIndex;
            Console.WriteLine("Average child is {0} years old", average.ToString("0.00"));
            Console.WriteLine("Oldest child is: {0}", oldestChild);


            // ADULTS
            Console.WriteLine();
            Console.WriteLine("ADULTS");
            for (int i = 0; i < adultIndex; i++)
            {
                Console.WriteLine("Adult {0} is {1} years old.", i + 1, adults[i]);
            }
            average = Convert.ToDouble(adultSum) / adultIndex;
            Console.WriteLine("Average adult is {0} years old", average.ToString("0.00"));
            Console.WriteLine("Oldest adult is: {0}", oldestAdult);

>>>>>>> programming-week5/master
            Console.ReadKey();
        }
    }
}
