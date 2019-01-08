using System;
using System.Collections.Generic;
using System.IO;


namespace Assignment3
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
            TranslateWords(ReadWords("dictionary.csv"));
        }

        /// <summary>
        ///  Read all words from a textfile and stores these words in a Dictionary
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>Dictionary of words</returns>
        Dictionary<string, string> ReadWords(string filename)
        {
            // Dict that holds all translations
            Dictionary<string, string> dutchDict = new Dictionary<string, string>();

            // String array containing dutch and english word
            string[] dictEntry = new string[2];

            // Read text file containing dictionary entries
            StreamReader reader = new StreamReader(filename);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                // Add translations to dict
                dictEntry = line.Split(';');
                dutchDict[dictEntry[0]] = dictEntry[1];
            }

            return dutchDict;
        }

        /// <summary>
        /// Read continously a Dutch word from the user until the word ‘stop’ has been entered.
        /// </summary>
        /// <param name="words"></param>
        void TranslateWords(Dictionary<string, string> words)
        {
            string word = "";

            while (word != "stop")
            {
                Console.Write("Enter a word: ");
                word = Console.ReadLine();

                if (word == "listall")
                {
                    ListAllWords(words);

                } else if (word != "stop")
                {
                    // Output translation
                    if (words.ContainsKey(word))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0} => {1}", word, words[word]);
                        Console.ResetColor();

                    // Notify user if given word is not found
                    } else
                    {
                        Console.WriteLine("word '{0}' not found", word);
                    }

                }
            }
        }        /// <summary>
        /// Display all words + translations of the dictionary
        /// </summary>
        /// <param name="words"></param>        void ListAllWords(Dictionary<string, string> words)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Iterate over a dictionary in utilizse the KeyValuePair data type
            foreach (KeyValuePair<string, string> entry in words)
            {
                Console.WriteLine("{0} => {1}", entry.Key, entry.Value);
            }
            Console.ResetColor();
        }
    }
}