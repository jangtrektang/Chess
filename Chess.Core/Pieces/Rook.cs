using System.Collections.Generic;
using System.Linq;
using Chess.Core.Enums;

namespace Chess.Core.Pieces
{
    public class Rook : Piece
    {
        public Rook(PieceColor color) : base(color)
        {

        }

        public Rook(PieceColor color, Square square) : base(color, square)
        {

        }

        public override IEnumerable<Move> GetPossibleMoves(Board board)
        {
            var moves = new List<Move>();
            var squares = board.GetSquares();

            for(var y = 0; y < 8; y++)
            {
                if (y == Square.Y)
                    continue;

                var piece = board.Pieces
                    .FirstOrDefault(p => p.Square.X == Square.X && p.Square.Y == y);

                if (piece == null)
                    moves.Add(new Move(Square, squares[y, Square.X]));

                if (piece == null || piece.Color == Color)
                    break;

                moves.Add(new Move(Square, squares[y, Square.X], piece));
                break;
            }

            for(var x = 0; x < 8; x++)
            {
                if (x == Square.X)
                    continue;

                var piece = board.Pieces
                    .FirstOrDefault(p => p.Square.X == x && p.Square.Y == Square.Y);

                if (piece == null)
                    moves.Add(new Move(Square, squares[Square.Y, x]));

                if (piece == null || piece.Color == Color)
                    continue;

                moves.Add(new Move(Square, squares[Square.Y, x], piece));
                break;
            }

            return moves;
        }

        public override string ToString()
        {
            return "Rook";
        }
    }
}
