using System;
using System.Collections.Generic;
using System.Linq;
using Chess.Core.Enums;

namespace Chess.Core.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(PieceColor color) : base(color)
        {

        }

        public Bishop(PieceColor color, Square square) : base(color, square)
        {

        }

        public override IEnumerable<Move> GetPossibleMoves(Board board)
        {
            var moves = new List<Move>();
            var squares = board.GetSquares();
            var y = 0;

            for (var x = 0; x < 8; x++)
            {
                if (Square.X == x && Square.Y == y)
                    continue;

                var differenceX = Math.Abs(Square.X - x);
                var differenceY = Math.Abs(Square.Y - y);

                if (differenceX != differenceY)
                    continue;

                var piece = board.Pieces
                    .FirstOrDefault(p => p.Square.X == x && p.Square.Y == y);

                if (piece == null)
                    moves.Add(new Move(Square, squares[y, x]));
                else
                {
                    if (piece.Color == Color)
                        break;

                    moves.Add(new Move(Square, squares[y, x], piece));
                    break;
                }
            }

            return moves;
        }

        public override string ToString()
        {
            return "Bishop";
        }
    }
}
