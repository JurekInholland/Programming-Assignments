using System;
using System.IO;

namespace Assignment4
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
            RegularCandies[,] playingField = new RegularCandies[8, 8];
            InitCandies(playingField);
            DisplayCandies(playingField);

            bool rowScored = ScoreRowPresent(playingField);
            bool colScored = ScoreColumnPresent(playingField);


            if (rowScored)
            {
                Console.WriteLine("row score!");
            }
            else
            {
                Console.WriteLine("no row score");
            }

            if (colScored)
            {
                Console.WriteLine("column score!");
            }
            else
            {
                Console.WriteLine("no column score");
            }

            Console.ReadKey();
        }

        void WritePlayingField(RegularCandies[,] playingField, string filename)
        {
            string line;
            StreamWriter writer = new StreamWriter(filename);

            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                line = "";

                for (int col = 0; col < playingField.GetLength(1); col++)
                {
                    line += playingField[row, col];
                }
                writer.WriteLine(line);
            }
            writer.Close();
        }

        RegularCandies[,] ReadPlayingField(string filename)
        {
            RegularCandies[,] playingField = new RegularCandies[8, 8];

            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                for (int col = 0; col < playingField.GetLength(1); col++)
                {

                }
            }

        }

        bool ScoreColumnPresent(RegularCandies[,] matrix)
        {
            // Give lastCandy an initial value so the compiler doesn't complain
            RegularCandies lastCandy = RegularCandies.Jellybean;

            int counter = 1;

            // Exactly like ScoreRowPresent but columns and rows switched
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    // Start from the second element, since the first cannot be compared to anything.
                    if (row + col != 0)
                    {
                        if (lastCandy == matrix[row, col])
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 1;
                        }

                        if (counter >= 3)
                        {
                            return true;
                        }
                    }
                    lastCandy = matrix[row, col];
                }
            }
            return false;
        }

        bool ScoreRowPresent(RegularCandies[,] matrix)
        {
            // Give lastCandy an initial value so the compiler doesn't complain
            RegularCandies lastCandy = RegularCandies.Jellybean;

            int counter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // Start from the second element, since the first cannot be compared to anything.
                    if (row + col != 0)
                    {
                        if (lastCandy == matrix[row, col])
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 1;
                        }

                        if (counter >= 3)
                        {
                            return true;
                        }
                    }
                    lastCandy = matrix[row, col];
                }
            }
            return false;
        }

        void InitCandies(RegularCandies[,] matrix)
        {
            Random rng = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (RegularCandies)rng.Next(1, 7);
                }
            }
        }

        void DisplayCandies(RegularCandies[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    switch (matrix[row, col])
                    {
                        case RegularCandies.Jellybean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case RegularCandies.Gum_Square:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case RegularCandies.Jujube_Cluster:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                    }
                    Console.Write("# ");
                }
                Console.WriteLine();

            }
            Console.ResetColor();
        }
    }
}