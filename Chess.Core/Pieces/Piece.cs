﻿using System.Collections.Generic;
using Chess.Core.Enums;

namespace Chess.Core.Pieces
{
    public abstract class Piece
    {
        public PieceColor Color { get; }
        public Square Square { get; set; }

        protected Piece(PieceColor color)
        {
            Color = color;
        }

        protected Piece(PieceColor color, Square square) 
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
