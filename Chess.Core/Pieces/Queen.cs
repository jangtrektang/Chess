using Chess.Core.Enums;
using System;
using System.Collections.Generic;

namespace Chess.Core
{
    public class Queen : Piece
    {
        public Queen(PieceColor color) : base(color)
        {

        }

        public Queen(PieceColor color, Square square) : base(color, square)
        {

        }

        public override IEnumerable<Move> GetPossibleMoves(Board board)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Queen";
        }
    }
}
