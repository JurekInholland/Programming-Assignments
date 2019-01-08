using System;
using System.Collections.Generic;

namespace Assignment02
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
            // Choose a word
            List<string> potentialWords = ListOfWords();
            string gameWord = SelectWord(potentialWords);

            // Init the game
            HangmanGame hangman = new HangmanGame();
            hangman.Init(gameWord);
            DisplayWord(hangman.guessedWord);
            bool playing = PlayHangman(hangman);

            // Evaluate if the player won or lost the game
            if (playing)
            {
                Console.WriteLine("You guessed the word!");
            } else
            {
                Console.WriteLine("You didn't guess the word...");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Return a predefined list of words
        /// </summary>
        /// <returns></returns>
        List<string> ListOfWords()
        {
            // Init list and set values in 1 line
            List<string> wordList = new List<string> { "trainstation", "planetarium", "roflcopter", "telephone", "noodle soup", "hangman", "programming", "assignment", "dictionary", "pseudocode"};

            return wordList;
        }

        /// <summary>
        /// Choose a random word from a list
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        string SelectWord(List<string> words)
        {
            int listLength = words.Count;
            Random rng = new Random();

            int randomWord = rng.Next(0, listLength);

            return words[randomWord];
        }

        /// <summary>
        /// Print a word with spaces inbetween letters
        /// </summary>
        /// <param name="word"></param>
        void DisplayWord(string word)
        {
            foreach (char c in word)
            {
                Console.Write("{0} ", c);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print a list with spaces inbetween letters
        /// </summary>
        /// <param name="letters"></param>
        void DisplayLetters(List<char> letters)
        {
            foreach (char c in letters)
            {
                Console.Write("{0} ", c);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Read a letter until a valid one is entered; return it
        /// </summary>
        /// <param name="blacklistLetters"></param>
        /// <returns></returns>
        char ReadLetter(List<char> blacklistLetters)
        {
            char letter = 'A';
            bool doesContain = true;

            while (doesContain)
            {
                Console.Write("Enter a letter: ");
                letter = Convert.ToChar(Console.ReadLine());
                doesContain = blacklistLetters.Contains(letter);
            }

            return letter;
        }

        /// <summary>
        /// Main loop; game logic
        /// </summary>
        /// <param name="hangman"></param>
        /// <returns></returns>
        bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();            int attempts = 8;
            bool wordGuessed = hangman.isGuessed();

            while (attempts > 0 && wordGuessed == false)
            {
                char letter = ReadLetter(enteredLetters);
                enteredLetters.Add(letter);

                // Deduct attempts if a wrong letter was entered
                if(!hangman.GuessLetter(letter))
                {
                    attempts--;
                }

                // Display current information
                Console.Write("Entered letters: ");
                DisplayLetters(enteredLetters);
                Console.WriteLine("{0} Attempts left.", attempts);
                Console.WriteLine();
                DisplayWord(hangman.guessedWord);
                Console.WriteLine();

                // Exit once the game is won
                wordGuessed = hangman.isGuessed();
                if (wordGuessed)
                {
                    return true;
                }
            }            return false;
        }
    }
}
