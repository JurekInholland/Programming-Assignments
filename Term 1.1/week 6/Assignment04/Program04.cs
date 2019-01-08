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

            // Call custom method with 3 out parameters
            SearchText(inputText, out int nrOfStops, out int nrOfCommas, out int nrOfSemicolons);

            // Output the result to the user
            Console.WriteLine("result: {0} full stops, {1} commas, {2} semicolons", nrOfStops, nrOfCommas, nrOfSemicolons);
            Console.ReadKey();
        }

        /// <summary>
        /// Takes a text string to search as well as 3 out variables.
        /// Counts and stores occurences of search strings in a text.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="char1"></param>
        /// <param name="char2"></param>
        /// <param name="char3"></param>
        /// <returns></returns>
        static void SearchText(string input, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfFullStops = 0;
            nrOfCommas = 0;
            nrOfSemiColons = 0;

            string char1 = ".";
            string char2 = ",";
            string char3 = ";";

            // Loop through each character in the search string
            // and count the occurences of the search strings.
            foreach (char c in input)
            {
                if (c == char1[0])
                {
                    nrOfFullStops++;
                }
                else if (c == char2[0])
                {
                    nrOfCommas++;
                }
                else if (c == char3[0])
                {
                    nrOfSemiColons++;
                }
            }
        }
    }
}
