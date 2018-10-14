using System;

namespace Assignment04
{
    class Program
    {
        /// <summary>
        /// Assignment 4 (Console Application)
        /// Enter a text(string). Determine the number of times that the characters
        /// . (full stop) , (comma) and ; (semi-colon) occur in this string. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Read the input text from the user
            Console.Write("Enter a text> ");
            string inputText = Console.ReadLine();

            // Assign a tuple of 3 ints to the return value of the custom search method.
            // The input text as well as the 3 characters ".", "," and ";"
            // are passed to the method as strings.
            (int firstOccurence, int secondOccurence, int thirdOccurence) = SearchText(inputText, ".", ",", ";");

            // Output the result to the user
            Console.WriteLine("result: {0} full stops, {1} commas, {2} semicolons", firstOccurence, secondOccurence, thirdOccurence);
            Console.ReadKey();

        }

        /// <summary>
        /// Takes a text string to search as well as 3 search strings.
        /// Returns a tuple of 3 ints, reflecting the number of occurences
        /// of each search string in the text.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="char1"></param>
        /// <param name="char2"></param>
        /// <param name="char3"></param>
        /// <returns></returns>
        static Tuple<int, int, int> SearchText(string input, string char1, string char2, string char3)
        {
            int occurence1 = 0;
            int occurence2 = 0;
            int occurence3 = 0;

            // Loop through each character in the search string
            // and count the occurences of the search strings.
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
            // Return the number of occurences as ints inside a tuple
            return Tuple.Create(occurence1, occurence2, occurence3);
        }
    }
}
