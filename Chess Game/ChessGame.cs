using System;

namespace Chess_Game
{
    class ChessGame
    {
        public ChessPiece[,] chessboard = new ChessPiece[8, 8];


        // Init chessboard in the class constructor; Ask if this is considered best practice.
        public ChessGame()
        {
            InitChessboard(chessboard);
        }


        void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = null;
                }
            }

            PutChessPieces(chessboard);
        }

        void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.King, ChessPieceType.Queen, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    // Set type
                    if (row == 1 || row == 6)
                    {
                        chessboard[row, col] = new ChessPiece();
                        chessboard[row, col].type = ChessPieceType.Pawn;

                    }
                    else if (row == 0 || row == 7)
                    {

                        chessboard[row, col] = new ChessPiece();

                        chessboard[row, col].type = order[col];
                    }

                    // Set color
                    if (row == 0 || row == 1)
                    {
                        chessboard[row, col].color = ChessPieceColor.White;
                    }

                    else if (row == 6 || row == 7)
                    {
                        chessboard[row, col].color = ChessPieceColor.Black;
                    }
                }
            }
        }

        public void CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            if (chessboard[from.field, from.column] == null)
            {
                Console.WriteLine("No chesspiece at from position!");
                return;
            }

            if (chessboard[to.field, to.column] != null)
            {
                Console.WriteLine("There is a pice on the to position.");
                return;
            }

            // check if valid

            bool isValid = ValidMove(chessboard[from.field, from.column], from, to);
            if (isValid)
            {
                DoMove(chessboard, from, to);
            }
            else
            {
                Console.WriteLine("Invalid move for chesspiece {0}", chessboard[from.field, from.column].type);
            }
        }

        bool ValidMove(ChessPiece chessPiece, Position from, Position to)
        {
            int ver = Math.Abs(from.field - to.field);
            int hor = Math.Abs(from.column - to.column);

            if (hor == 0 && ver == 0)
            {
                return false;
            }
            else
            {
                switch (chessPiece.type)
                {
                    case ChessPieceType.Bishop:
                        if (hor == ver)
                        {
                            return true;
                        }
                        break;

                    case ChessPieceType.King:
                        if (hor == 1 || ver == 1 || hor == 1 && ver == 1)
                        {
                            return true;
                        }
                        break;

                    case ChessPieceType.Knight:
                        if (hor * ver == 2)
                        {
                            return true;
                        }
                        break;

                    case ChessPieceType.Pawn:
                        if (hor == 0 && ver == 1)
                        {
                            return true;
                        }
                        break;

                    case ChessPieceType.Queen:
                        if (hor * ver == 0 || hor == ver)
                        {
                            return true;
                        }
                        break;

                    case ChessPieceType.Rook:
                        if (hor * ver == 0)
                        {
                            return true;
                        }
                        break;

                }
                return false;
            }


        }

        void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            chessboard[to.field, to.column] = chessboard[from.field, from.column];
            chessboard[from.field, from.column] = null;
        }

    }
}
