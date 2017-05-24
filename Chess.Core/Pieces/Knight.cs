using System.Collections.Generic;
using Chess.Core.Enums;
using System.Linq;

namespace Chess.Core.Pieces
{
    public class Knight : Piece
    {
        public Knight(PieceColor color) : base(color)
        {

        }

        public Knight(PieceColor color, Square square) : base(color, square)
        {

        }

        public override IEnumerable<Move> GetPossibleMoves(Board board)
        {
            var moves = new List<Move>();
            var x = Square.X;
            var y = Square.Y;

            var squares = new List<Square>
            {
                board.GetSquare(y + 1, x + 2),
                board.GetSquare(y - 1, x + 2),
                board.GetSquare(y + 1, x - 2),
                board.GetSquare(y - 1, x - 2),
                board.GetSquare(y + 2, x + 1),
                board.GetSquare(y + 2, x - 1),
                board.GetSquare(y - 2, x + 1),
                board.GetSquare(y - 2, x - 1)
            };


            foreach (var square in squares)
            {
                var piece = board.Pieces
                    .FirstOrDefault(p => p.Square.Equals(square));

                if (piece == null)
                {
                    moves.Add(new Move(Square, square));
                    continue;
                }

                if (piece.Color == Color)
                    continue;

                moves.Add(new Move(Square, square, piece));
            }

            return moves;
        }

        public override string ToString()
        {
            return "Knight";
        }
    }
}
