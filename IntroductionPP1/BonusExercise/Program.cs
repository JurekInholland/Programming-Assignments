using System;

namespace BonusExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Practice addition:");

            Random rnd = new Random();

            // generate 4 random integers
            int number1 = rnd.Next(101, 9999);
            int number2 = rnd.Next(101, 9999);
            int number3 = rnd.Next(101, 9999);
            int number4 = rnd.Next(101, 9999);

            // Prompt the user to add up the numbers
            Console.WriteLine("Please add the following numbers:");
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);

            // Ask the user for his solution
            Console.WriteLine();
            Console.WriteLine("Please enter your solution:");

            string user_solution;
            user_solution = Console.ReadLine();

            // Calculate the correct solution
            int solution = number1 + number2 + number3 + number4;


            // Check if the user input is correct
            if (int.Parse(user_solution) == solution) {
                Console.WriteLine("You got it right! The answer is {0}", solution);

            }
            else {
                Console.WriteLine("You got it wrong! Thw correct answer is {0}", solution);
            }

            Console.ReadKey();
        }
    }
}
