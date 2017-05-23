using System.Collections.Generic;
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
            return moves;
        }

        public override string ToString()
        {
            return "King";
        }
    }
}
