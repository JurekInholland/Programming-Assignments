using System;
using System.Collections.Generic;

namespace Assignment3
{
    class YahtzeeGame
    {
        // Create die array with 5 dice
        Dice[] dice = new Dice[5];

        public string wincondition;


        public void Init()
        {
            // Create a die for every array element
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Dice();
            }
        }

        public void Throw()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Throw();
            }
        }

        public void DisplayValues()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].DisplayValue();
            }
            // Add a newline in the end
            Console.WriteLine();
        }

        /// <summary>
        /// Determine if a Yahtzee has been rolled
        /// </summary>
        /// <returns></returns>
        public bool Yahtzee()
        {
            wincondition = "Yahtzee";

            for (int i = 1; i < dice.Length; i++)
            {
                // Return false as soon as one die roll differs from the first one
                if (dice[0].value != dice[i].value)
                {
                    return false;
                }
            }
            // If all subsequent rolls are equal to the first one, return true
            return true;
        }

        /// <summary>
        /// Determine if a 4 of a kind has been rolled
        /// </summary>
        /// <returns></returns>
        public bool FourOfAKind()
        {
            wincondition = "Four of a kind";

            // Create an int array with 6 elements, one for each possible die result
            int[] results = new int[6];

            // Set every element of the result array to zero
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = 0;
            }

            // Increment result array element that corresponds with the rolled result, by 1
            for (int i = 0; i < dice.Length; i++)
            {
                results[dice[i].value - 1] += 1;
            }

            // Iterate through all results and check if any one is 4 or above
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] >= 4)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Takes an int x and returns the number that has been rolled x times. Else returns zero.
        /// </summary>
        /// <returns></returns>
        public int XofAKind(int x)
        {
            int[] results = new int[6];

            // Set every value of result array to zero
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = 0;
            }

            // Increment result array element that corresponds with the rolled result by 1
            for (int i = 0; i < dice.Length; i++)
            {
                results[dice[i].value - 1] += 1;
            }

            // Iterate through all results and check if any one is greater than x
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] >= x)
                {
                    return results[i];
                }
            }
            return 0;
        }

        public bool ThreeOfAKind()
        {
            wincondition = "Three of a kind";

            if (XofAKind(3) > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool FullHose()
        {
            wincondition = "Full House";

            // Return true if both a "2 of a kind" and a "3 of a kind" have occured and both numbers differ
            if (XofAKind(2) != 0 && XofAKind(3) != 0 && XofAKind(2) != XofAKind(3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Straight(int x)
        {
            wincondition = String.Format("{0} in a row", x);


            List<int> resultList = new List<int>();
            int consecutives = 1;

            // Add all roll results to a list and sort it
            for (int i = 0; i < dice.Length; i++)
            {
                resultList.Add(dice[i].value);
            }

            resultList.Sort();

            // Iterate through the results list
            for (int i = 0; i < resultList.Count; i++)
            {

                // Start on second iteration
                if (i > 0)
                {
                    // Check if result is 1 larger than previous
                    if (resultList[i] == resultList[i - 1] + 1)
                    {
                        consecutives++;
                    }
                    else
                    {
                        consecutives = 1;
                    }                     
                }
            }

            if (consecutives >= x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
