using System;

namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user for their age
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();

            // Convert the text (string) to an integer
            int age = int.Parse(input);

            // Perform calculations on the age
            age = age + 1;

            // convert integer back to string
            string output = age.ToString();

            // Show the increased age to the user
            Console.WriteLine("Next year you will be {0} years old.", output);

            Console.ReadKey();

        }
    }
}
