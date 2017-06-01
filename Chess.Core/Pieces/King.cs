using System.Collections.Generic;
using System.Linq;
using Chess.Core.Enums;

namespace Chess.Core.Pieces
{
    public class King : Piece
    {
        public King(PieceColor color) : base(color)
        {

        }

        public King(PieceColor color, Square square) : base(color, square)
        {

        }

        public override IEnumerable<Move> GetPossibleMoves(Board board)
        {
            var moves = new List<Move>();
            var x = Square.X;
            var y = Square.Y;

            var squares = new List<Square>
            {
                board.GetSquare(x - 1, y),
                board.GetSquare(x + 1, y),
                board.GetSquare(x, y + 1),
                board.GetSquare(x, y - 1),
                board.GetSquare(x - 1, y + 1),
                board.GetSquare(x - 1, y - 1),
                board.GetSquare(x + 1, y + 1),
                board.GetSquare(x + 1, y - 1)
            };

            foreach (var square in squares)
            {
                if (square == null)
                    continue;

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
            return "King";
        }
    }
}
