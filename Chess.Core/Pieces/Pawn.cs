using Chess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Core
{
    public class Pawn : Piece
    {
        private bool _hasMoved;

        public Pawn(PieceColor color) : base(color)
        {
            _hasMoved = false;
        }

        public Pawn(PieceColor color, Square square) : base(color, square)
        {
            _hasMoved = false;
        }

        public override IEnumerable<Move> GetPossibleMoves(Board board)
        {       
            var moves = new List<Move>();
            var squares = board.GetSquares();
            var y = Color == PieceColor.Black 
                ? Square.Y + 1 
                : Square.Y - 1;

            var piece = board.Pieces
                .Where(x => x.Square.Y == y && x.Square.X == Square.X)
                .FirstOrDefault();

            var square = squares[y, Square.X];

            if (piece == null)
                moves.Add(new Move(Square, square));

            var pieces = board.Pieces
               .Where(x => x.Square.Y == y && (x.Square.X == Square.X + 1 || x.Square.X == Square.X - 1));

            foreach(var tempPiece in pieces)
            {
                moves.Add(new Move(Square, tempPiece.Square));
            }

            if (!_hasMoved)
            {
                y = Color == PieceColor.Black
                ? Square.Y + 2
                : Square.Y - 2;

                piece = board.Pieces
                    .Where(x => x.Square.Y == y && x.Square.X == Square.X)
                    .FirstOrDefault();

                square = squares[y, Square.X];

                if (piece == null)
                    moves.Add(new Move(Square, square));
            }           

            return moves;
        }

        public override void Move(Square square)
        {
            base.Move(square);

            _hasMoved = true;
        }

        public override string ToString()
        {
            return "Pawn";
        }
    }
}
