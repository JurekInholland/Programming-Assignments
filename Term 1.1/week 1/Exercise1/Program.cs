using System;

namespace Exercise1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Make the program more user friendly by asking for their name:
            Console.WriteLine("Please enter your name.");

            string name;
            name = Console.ReadLine();

            // ... And age
            Console.WriteLine("Please enter your age.");
            string age = Console.ReadLine();

            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);

            Console.ReadKey();
        }
    }
}
