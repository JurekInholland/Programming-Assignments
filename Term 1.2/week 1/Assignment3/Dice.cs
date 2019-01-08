using System;

namespace Assignment3
{
    class Dice
    {
        const int SIDES = 6;

        public int value;
        static Random rng = new Random();

        public void Throw()
        {
            // Generate a random number between 1 and 6
            this.value = rng.Next(1, SIDES + 1);
        }

        public void DisplayValue()
        {
            Console.Write("{0} ", this.value);
        }
    }

}


