using Chess.Core.Enums;
using System;
using System.Collections.Generic;

namespace Chess.Core
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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Bishop";
        }
    }
}
