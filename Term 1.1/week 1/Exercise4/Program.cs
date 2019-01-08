using System;

namespace Exercise4
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please tell me your age.");

            string age;
            age = Console.ReadLine();

            const int tooOld = 65;

            if (int.Parse(age) > tooOld) {
                Console.WriteLine("You are too old.");
            }

            else {
                Console.WriteLine("Fortunately, you are not too old yet.");
            }

        }
    }
}
