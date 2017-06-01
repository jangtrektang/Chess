using System.Collections.Generic;
using Chess.Core;
using Chess.Core.Pieces;

namespace Chess.Tests.Comparers
{
    internal class MoveComparer : Comparer<Move>
    {
        public override int Compare(Move x, Move y)
        {
            return CompareMove(x, y);
        }

        private static int CompareMove(Move x, Move y)
        {
            if (x.StartSquare.Equals(y.StartSquare) && x.EndSquare.Equals(y.EndSquare) && ComparePiece(x.CapturedPiece, y.CapturedPiece))
                return 0;

            return -1;
        }

        private static bool ComparePiece(Piece x, Piece y)
        {
            if (x == null && y == null)
                return true;

            return x != null && x.Equals(y);
        }
    }
}
