using Chess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public abstract class Piece
    {
        public PieceColor Color { get; }
        public Square Square { get; set; }

        public Piece(PieceColor color)
        {
            Color = color;
        }

        public Piece(PieceColor color, Square square) 
            : this(color)
        {
            Square = square;
        }        

        public virtual void Move(Square square)
        {
            Square = square;
        }

        public abstract IEnumerable<Move> GetPossibleMoves(Board board);
    }
}
