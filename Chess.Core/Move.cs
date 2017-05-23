using Chess.Core.Pieces;

namespace Chess.Core
{
    public class Move
    {
        public Square StartSquare { get; set; }
        public Square EndSquare { get; set; }
        public Piece CapturedPiece { get; set; }

        public Move(Square startSquare, Square endSquare)
        {
            StartSquare = startSquare;
            EndSquare = endSquare;
        }

        public Move(Square startSquare, Square endSquare, Piece capturedPiece)
            : this(startSquare, endSquare)
        {
            CapturedPiece = capturedPiece;
        }
    }
}
