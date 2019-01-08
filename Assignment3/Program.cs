using System;
using System.IO;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
            Program prog = new Program();
            prog.Start();
        }

        void Start()
        {
            string word = ReadString("Enter a word: ");
            Console.WriteLine();
            int occurences = SearchWordInFile("tweets.txt", word);
            Console.WriteLine("{0} occurences", occurences);
            Console.ReadKey();

        }

        /// <summary>
        /// Takes a string and highlights all occurences of the given word in red
        /// </summary>
        /// <param name="line">Entire text string to process</param>
        /// <param name="word">Word to highlight</param>
        void DisplayAllWordsInLine2(string line, string word)
        {
            // Loop as long as the remaining text contains the word to highlight 
            while (WordInLine(line, word))
            {
                // Get the position of the word within the string
                int position = line.ToLower().IndexOf(word.ToLower());

                // Create a substring containing everything until the search string
                string first = line.Substring(0, position);

                // Create a substring containing the word to highlight
                string colored = line.Substring(position, word.Length);

                // Process the remaining string further
                line = line.Substring(position + word.Length);

                Console.Write(first);

                // Highlight word
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(colored);

                Console.ResetColor();
            }

            // Print the last part of the last substring
            Console.Write(line);

            Console.WriteLine();
            Console.WriteLine();

        }

        /// <summary>
        /// Returns true if the given line contains the given word
        /// </summary>
        /// <param name="line"></param>
        /// <param name="word"></param>
        bool WordInLine(string line, string word)
        {
            if (line.ToLower().Contains(word.ToLower()))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Counts the number of occurences of the given word within the given text file
        /// </summary>
        /// <param name="filename">Path to the text file</param>
        /// <param name="word">Word to search</param>
        /// <returns>Number of occurences of the word</returns>
        int SearchWordInFile(string filename, string word)
        {
            StreamReader reader = new StreamReader(filename);
            int occurences = 0;

            // Iterate over all lines in text file
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (WordInLine(line, word))
                {
                    // Count occurences
                    occurences++;

                    // Display the line; highlight the word
                    DisplayAllWordsInLine2(line, word);
                }
            }
            reader.Close();
            return occurences;
        }

        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }


        
    }

    
}
