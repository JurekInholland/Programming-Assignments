using System;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        /// <summary>
        /// Roll dice until win condition is reached
        /// </summary>
        void Start()
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();

            yahtzeeGame.Init();

            bool stop = false;
            int index = 0;

            while (stop == false)
            {
                yahtzeeGame.Throw(); // throw dice

                yahtzeeGame.DisplayValues(); // display result

                // Check for win condition
                stop = yahtzeeGame.Yahtzee();

                //stop = yahtzeeGame.FourOfAKind();

                //stop = yahtzeeGame.ThreeOfAKind();

                stop = yahtzeeGame.FullHose();

                //stop = yahtzeeGame.Straight(5);

                index++;
            }

            Console.WriteLine("Number of attempts needed ({0}): {1}", yahtzeeGame.wincondition, index);

            Console.ReadKey();
        }
    }
}
