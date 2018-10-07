using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text> ");
            string inputText = Console.ReadLine();
            var test = SearchText(inputText, ".", ";", ",");
            Console.Write(test);
            Console.WriteLine("result: {0} full stops, {1} commas, {2} semicolons", test[0], test[1], test[2]);
            Console.ReadKey();

        }
        static Tuple<int, int, int> SearchText(string input, string char1, string char2, string char3)
        {
            int occurence1 = 0;
            int occurence2 = 0;
            int occurence3 = 0;
            foreach (char c in input)
            {
                if (c == char1[0])
                {
                    occurence1++;
                }
                else if (c == char2[0])
                {
                    occurence2++;
                }
                else if (c == char3[0])
                {
                    occurence3++;
                }
            }

            return Tuple.Create(occurence1, occurence2, occurence3);
        }
    }
}
