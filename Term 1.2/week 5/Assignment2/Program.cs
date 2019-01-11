using System;
using System.IO;
using CandyCrushLogic;

namespace Assignment2
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

            RegularCandies[,] playingField = new RegularCandies[8, 8]; ;

            string filename = "playingfield.txt";

            bool fileread = false;

            if (File.Exists(filename))
            {
                Console.WriteLine("Loading");
                try
                {
                    playingField = ReadPlayingField(filename);
                    fileread = true;
                }

                catch (Exception)
                {
                    fileread = false;
                }


            }

            if (!fileread)
            {
                Console.WriteLine("Generating new field");
                playingField = new RegularCandies[8, 8];
                InitCandies(playingField);

                WritePlayingField(playingField, filename);
            }

            DisplayCandies(playingField);

            bool rowScored = CandyCrusher.ScoreRowPresent(playingField);
            bool colScored = CandyCrusher.ScoreColumnPresent(playingField);


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


        RegularCandies[,] ReadPlayingField(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            RegularCandies[,] playingField = new RegularCandies[8, 8];

            int currentRow = 0;
            int currentCol = 0;


            try
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    foreach (Char c in line)
                    {

                        bool readChar = int.TryParse(c.ToString(), out int fieldValue);
                        playingField[currentRow, currentCol] = (RegularCandies)fieldValue;

                        if (currentCol < 7)
                        {
                            currentCol++;
                        }
                        else
                        {
                            currentCol = 0;
                            currentRow++;
                        }

                    }

                }
            }



            // Make sure reader is always closed
            finally
            {
                reader.Close();
            }


            return playingField;

        }


        /// <summary>
        /// Writes a playing field state to a text file
        /// </summary>
        /// <param name="playingField">The playing field to save</param>
        /// <param name="filename">The filename of the text file</param>
        void WritePlayingField(RegularCandies[,] playingField, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);

            string line = "";

            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                for (int col = 0; col < playingField.GetLength(1); col++)
                {
                    line += (int)playingField[row, col];
                }
                writer.WriteLine(line);
                line = "";
            }

            writer.Close();
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