using System;
using System.Collections.Generic;


namespace LingoGame
{
    class Program
    {
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            PlayLingo(ChooseWord(ReadWords()));
        }

        string[] ReadWords()
        {
            return new string[] { "green", "class", "sharp" };
        }

        string ChooseWord(string[] words)
        {
            Random rnd = new Random();
            return words[rnd.Next(1, words.Length)];
        }

        void PlayLingo(string lingoWord)
        {
            int attemptsLeft = 5;
            bool guessed = false;

            while (!guessed || attemptsLeft > 0)
            {

                string playerWord = ReadPlayerWord(lingoWord.Length, attemptsLeft);
                DisplayResults(playerWord, EvaluateWord(playerWord, lingoWord));

                guessed = IsGuessed(lingoWord, playerWord);
                if (guessed)
                {
                    Console.WriteLine("You have guessed the word!");
                    break;
                }
                attemptsLeft--;
            }
        }

        string ReadPlayerWord(int wLength, int attempts)
        {
            string word = "";

            do
            {
                int attempt = 6 - attempts;
                Console.Write("Enter a (5-letter) word, attempt {0}: ", attempt);

                word = Console.ReadLine();
            } while (word.Length != wLength);


            return word;

        }

        int[] EvaluateWord(string playerWord, string lingoWord)
        {
            List<char> refLetters = new List<char>();

            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (playerWord[i] != lingoWord[i])
                {
                    refLetters.Add(lingoWord[i]);
                }
            }

            int[] results = new int[playerWord.Length];

            for (int i = 0; i < playerWord.Length; i++)
            {
                if (playerWord[i] == lingoWord[i])
                {
                    results[i] = 2;
                }
                else if (refLetters.Contains(playerWord[i]))
                {
                    results[i] = 1;
                    refLetters.Remove(playerWord[i]);
                }
                else
                {
                    results[i] = 0;
                }
            }

            return results;
        }

        void DisplayResults(string playerWord, int[] results)
        {
            for (int i = 0; i < playerWord.Length; i++)
            {
                if (results[i] == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                } else if (results[i] == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }

                Console.Write(playerWord.ToUpper()[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        bool IsGuessed(string lingoWord,  string playerWord)
        {
            if (lingoWord == playerWord)
            {
                return true;
            }

            return false;
        }
    }

}