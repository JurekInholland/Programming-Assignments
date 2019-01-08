using System;


namespace Chess_Game
{
    class Program
    {
        // Ask for difference between instantiating here or within class constructor
        ChessGame chessgame = new ChessGame();

        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            DisplayChessboard(chessgame.chessboard);
            PlayChess(chessgame.chessboard);
        }

       

        void DisplayChessboard(ChessPiece[,] chessboard)
        {

            string[] colLetters = { "  ", "A ", "B ", "C ", "D ", "E ", "F ", "G ", "H " };

            for (int row = 0; row < chessboard.GetLength(0) + 1; row++)
            {
                for (int col = 0; col < chessboard.GetLength(1) + 1; col++)
                {
                    if (row == 0)
                    {
                        Console.Write("{0} ", colLetters[col]);
                        continue;
                    }
                    else if (col == 0)
                    {
                        Console.Write("{0} ", row);
                        continue;
                    }

                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }

                    DisplayChessPiece(chessboard[row - 1, col - 1]);

                    Console.ResetColor();

                }
                Console.WriteLine();
            }
        }


        
        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece == null)
            {
                Console.Write("   ");
                return;
            };
            if (chessPiece.color == ChessPieceColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            switch (chessPiece.type)
            {
                case ChessPieceType.Bishop:
                    Console.Write(" b ");
                    break;
                case ChessPieceType.King:
                    Console.Write(" K ");
                    break;
                case ChessPieceType.Knight:
                    Console.Write(" k ");
                    break;
                case ChessPieceType.Pawn:
                    Console.Write(" p ");
                    break;
                case ChessPieceType.Queen:
                    Console.Write(" Q ");
                    break;
                case ChessPieceType.Rook:
                    Console.Write(" r ");
                    break;
            }

            Console.ResetColor();

        }

        Position ReadPosition(string question)
        {
            bool validPosition = false;
            int row = 0;
            int column = 0;

            while (validPosition == false)
            {
                Console.Write(question);
                string userPos = Console.ReadLine().ToUpper();

                column = userPos[0] - 'A';
                row = int.Parse(userPos[1].ToString()) - 1;

                if (column <= 8 && row <= 8)
                {
                    validPosition = true;
                }

            }
            Position playerPos = new Position();
            playerPos.field = row;
            playerPos.column = column;
            return playerPos;

        }

        void PlayChess(ChessPiece[,] chessboard)
        {
            while (true)
            {
                try
                {
                    Position from = ReadPosition("Enter from posi: ");
                    Position to = ReadPosition("Enter to posi: ");
                    chessgame.CheckMove(chessboard, from, to);
                }
                catch
                {
                    Console.WriteLine("Please enter a valid position!");
                }


                // Check if move is valid

                // Do move


                DisplayChessboard(chessboard);

            }
        }

        

        
    }
}