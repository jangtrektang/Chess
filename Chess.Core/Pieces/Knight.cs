using Chess.Core.Enums;
using System;
using System.Collections.Generic;

namespace Chess.Core
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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Knight";
        }
    }
}
