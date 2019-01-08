using System;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            PrintMonths();

            Console.WriteLine();

            // store user input month
            Month inputMonth = ReadMonth("Enter a month number: ");

            // Display correspondence
            Console.Write("{0} => ", (int)inputMonth);

            PrintMonth(inputMonth);

            Console.ReadKey();
        }

        /// <summary>
        /// Prints a given month.
        /// </summary>
        /// <param name="month"></param>
        void PrintMonth(Month month)
        {
            Console.WriteLine(month);
        }

        /// <summary>
        /// Print all months
        /// </summary>
        void PrintMonths()
        {
            // Loop through all months (jan to dec)
            for (Month m = Month.January; m <= Month.December; m++)
            {
                // Add a right-aligned index number in front
                Console.Write("{0,2}. ", (int)m);

                PrintMonth(m);
            }
        }

        /// <summary>
        /// Ask user for a month number and return the actual month.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        Month ReadMonth(string question)
        {
            bool validEnumValue = false;
            int index = 0;

            // Only exit loop when a valid value is entered
            while (validEnumValue == false)
            { 
                Console.Write(question);

                // Get index or 'month number' from user
                index = Convert.ToInt32(Console.ReadLine());

                // Check if the entered int corresponds with a defined enum value;
                if (Enum.IsDefined(typeof(Month), index))
                {
                    // .. If so, exit loop
                    validEnumValue = true;
                }

                else
                {
                    Console.WriteLine("{0} is not a valid value.", index);
                }
            }
            return (Month)index;
        }
    }
}
