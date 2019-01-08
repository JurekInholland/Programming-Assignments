using System;

namespace Exercise3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int score = 200;
            int level = 3;
            int nItems = 4;

            int score_new, level_new;

            // Increase score and level
            score_new = score++;

            level_new = level++;

            // Increase nItems by 5
            nItems += 5;

            // Output new values
            Console.WriteLine("Score (old): {0}, score (new): {1}", score_new, score);

            Console.WriteLine("level (old): {0}, level (new): {1}", level_new, level);

            Console.WriteLine("number of items: {0}", nItems);

            Console.ReadKey();
        }
    }
}
