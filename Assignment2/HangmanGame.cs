using System.Linq;

namespace Assignment02
{
    class HangmanGame
    {
        public string secretWord;
        public string guessedWord;

        /// <summary>
        /// Initialize by generating the scret word
        /// </summary>
        /// <param name="secretWord"></param>
        public void Init(string secretWord)
        {
            this.secretWord = secretWord;

            foreach (char c in secretWord)
            {
                guessedWord += ".";
            }
        }

        /// <summary>
        /// Check if the secret word contains an user-input letter; Update the guessed word
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        public bool GuessLetter(char letter)
        {
            bool containsLetter = false;

            if (secretWord.Contains(letter))
            {
                containsLetter = true;

                string newGuess = "";

                for (int j = 0; j < guessedWord.Length; j++)
                {

                    if (secretWord[j] == letter)
                    {
                        newGuess += letter;
                    }
                    else
                    {
                        newGuess += guessedWord[j];
                    }
                }
                guessedWord = newGuess;
            }
            return containsLetter;
        }

        /// <summary>
        /// Check if the word has been guessed
        /// </summary>
        /// <returns></returns>
        public bool isGuessed()
        {
            if (secretWord == guessedWord)
            {
                return true;
            }
            return false;
        }
    }
}
