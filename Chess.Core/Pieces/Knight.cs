using System.Collections.Generic;
using Chess.Core.Enums;

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

            var xLeft = Square.X - 2;
            var xRight = Square.X + 2;
            var yUp = Square.Y + 2;
            var yDown = Square.Y + 2;



            return moves;
        }

        public override string ToString()
        {
            return "Knight";
        }
    }
}
