using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Core;
using Chess.Core.Players;
using Chess.Core.Enums;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            var playerOne = new HumanPlayer("PlayerOne", PieceColor.White);
            var playerTwo = new HumanPlayer("PlayerTwo", PieceColor.Black);

            game.AddPlayer(playerOne);
            game.AddPlayer(playerTwo);

            game.StartGame();

            PrintBoard(game.Board);

            GetAvailableMoves(game.Board.Pieces[9], game.Board);

            Console.Read();
        }

        public static void PrintBoard(Board board)
        {
            var squares = board.GetSquares();

           for(var y = 0; y < 8; y++)
            {
                for(var x = 0; x < 8; x++)
                {
                    var piece = board.Pieces
                        .Where(p => p.Square.X == x && p.Square.Y == y)
                        .FirstOrDefault();

                    Console.Write("[{0}]", piece != null ? piece.ToString().Substring(0, 1) : " ");
                }

                Console.WriteLine();
            }
        }

        public static void GetAvailableMoves(Piece piece, Board board)
        {
            foreach(var move in piece.GetPossibleMoves(board))
            {
                Console.WriteLine("Possible move: {0}", move.EndSquare);
            }
        }
    }
}
