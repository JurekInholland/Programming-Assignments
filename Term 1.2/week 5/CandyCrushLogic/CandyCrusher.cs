
namespace CandyCrushLogic
{
    public class CandyCrusher
    {
        public static bool ScoreColumnPresent(RegularCandies[,] matrix)
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

        public static bool ScoreRowPresent(RegularCandies[,] matrix)
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
    }
}
