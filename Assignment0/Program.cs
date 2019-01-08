using System;

namespace Assignment0
{
    class Program
    {

        /// <summary>
        /// Application entry point;
        /// From now on, Main will only call the Start method of Program.
        /// </summary>
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        /// <summary>
        /// Start is used to call other methods of the Program.
        /// </summary>
        void Start()
        {
            int value = ReadInt("Enter a value: ");
            Console.WriteLine("You entered {0}.", value);

            int age = ReadInt("How old are you? ", 0, 120);
            Console.WriteLine("You are {0} years old.", age);

            string name = ReadString("What is your name? ");
            Console.WriteLine("Nice meeting you {0}.", name);

            Console.ReadKey();

        }

        /// <summary>
        /// Print a given question and return it's answer as int.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        int ReadInt(string question)
        {
            Console.Write(question);
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Overload ReadInt and additionally check if the input value is within a certain range.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        int ReadInt(string question, int min, int max)
        {
            // Call the original ReadInt method
            int result = ReadInt(question);

            // Ask again if the result is out of bounds
            while (result < min || result > max)
            {
                result = ReadInt(question);
            }

            return result;
        }

        /// <summary>
        /// Ask for a question and return the answer.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }

}
