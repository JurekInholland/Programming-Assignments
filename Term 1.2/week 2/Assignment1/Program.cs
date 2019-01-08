using System;

namespace Assignment1
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
<<<<<<< HEAD
            PrintMonths();

            Console.WriteLine();

            // store user input month
            Month inputMonth = ReadMonth("Enter a month number: ");

            // Display correspondence
            Console.Write("{0} => ", (int)inputMonth);

            PrintMonth(inputMonth);
=======
            int[,] array1 = new int[8, 8];

            Console.WriteLine("Testing dimensions: 8x8");

            InitMatrix2D(array1);
            DisplayMatrix(array1);

            Console.WriteLine();
            Console.WriteLine("Testing dimensions: 11x11");
            int[,] array2 = new int[11, 11];

            InitMatrix2D(array2);
            DisplayMatrix(array2);


            Console.WriteLine();
            Console.WriteLine();

            int[,] array2dNew = new int[11, 11];

            InitMatrixLinear(array2dNew);

            DisplayMatrixWithCross(array2dNew);


            int[,] userArray = ReadDimensions();
            InitMatrixLinear(userArray);

            DisplayMatrixWithCross(userArray);


>>>>>>> programming2-week2/master

            Console.ReadKey();
        }

        /// <summary>
<<<<<<< HEAD
        /// Prints a given month.
        /// </summary>
        /// <param name="month"></param>
        void PrintMonth(Month month)
        {
            Console.WriteLine(month);
        }

        /// <summary>
        /// Print all months
        /// </summary>
        void PrintMonths()
        {
            // Loop through all months (jan to dec)
            for (Month m = Month.January; m <= Month.December; m++)
            {
                // Add a right-aligned index number in front
                Console.Write("{0,2}. ", (int)m);

                PrintMonth(m);
            }
        }

        /// <summary>
        /// Ask user for a month number and return the actual month.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        Month ReadMonth(string question)
        {
            bool validEnumValue = false;
            int index = 0;

            // Only exit loop when a valid value is entered
            while (validEnumValue == false)
            { 
                Console.Write(question);

                // Get index or 'month number' from user
                index = Convert.ToInt32(Console.ReadLine());

                // Check if the entered int corresponds with a defined enum value;
                if (Enum.IsDefined(typeof(Month), index))
                {
                    // .. If so, exit loop
                    validEnumValue = true;
                }

                else
                {
                    Console.WriteLine("{0} is not a valid value.", index);
                }
            }
            return (Month)index;
        }
=======
        /// Read user input dimensions and returns a multidimensional array of said dimensions.
        /// </summary>
        /// <returns></returns>
        int[,] ReadDimensions()
        {
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            return new int[rows, columns];
        }

        void InitMatrix2D(int[,] matrix)
        {
            int counter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = counter;

                    counter++;
                }
            }
        }

        void InitMatrixLinear(int[,] matrix)
        {
            // start with row zero column zero
            int row = 0;
            int col = 0;

            // Iterate through the entire array length
            for (int i = 1; i <= matrix.Length; i++)
            {
                // Set array value to i
                matrix[row, col] = i;

                col++;

                // Reset column counter and increment row, once the end of a row is reached
                if (col >= matrix.GetLength(1))
                {
                    row++;
                    col = 0;
                }
            }
        }


        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        void DisplayMatrixWithCross(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // Color 0,0 , 1,1 , 2,2 etc in red
                    if (row == col)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    // Don't use else if here since both cases can apply simultaneously (once in the center when sides are uneven)
                    if (col == matrix.GetLength(1) - (row + 1))
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write("{0,3} ", matrix[row, col]);

                    Console.ResetColor();
                }
                // newline after each row
                Console.WriteLine();
            }
        }

>>>>>>> programming2-week2/master
    }
}
