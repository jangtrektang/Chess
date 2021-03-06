﻿using System;
using System.Collections.Generic;
using System.Linq;
using Chess.Core.Enums;
using Chess.Core.Pieces;

namespace Chess.Core
{
    public class Board
    {
        private Square[,] _squares;
        public IList<Piece> Pieces { get; set; }

        public Board()
        {
            CreateBoard();
        }

        private void CreateBoard()
        {
            _squares = new Square[8, 8];
            for(var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 8; x++)
                {
                    _squares[y, x] = new Square(x, y);
                }
            }
        }

        public void SetupPieces()
        {
            Pieces = new List<Piece>();

            foreach(var square in _squares)
            {
                if (square.Y == 1 || square.Y == 6)
                    Pieces.Add(new Pawn(square.Y == 1
                        ? PieceColor.Black
                        : PieceColor.White, square));

                if(square.Y == 0 || square.Y == 7)
                {
                    if (square.X == 0 || square.X == 7)
                        Pieces.Add(new Rook(square.Y == 0
                            ? PieceColor.Black
                            : PieceColor.White, square));

                    if (square.X == 1 || square.X == 6)
                        Pieces.Add(new Knight(square.Y == 0
                            ? PieceColor.Black
                            : PieceColor.White, square));

                    if (square.X == 2 || square.X == 5)
                        Pieces.Add(new Bishop(square.Y == 0
                            ? PieceColor.Black
                            : PieceColor.White, square));

                    if (square.X == 3)
                        Pieces.Add(new Queen(square.Y == 0
                            ? PieceColor.Black
                            : PieceColor.White, square));

                    if (square.X == 4)
                        Pieces.Add(new King(square.Y == 0
                            ? PieceColor.Black
                            : PieceColor.White, square));
                }
            }
        }

        public void MovePiece(Square startSquare, Square endSquare, PieceColor color)
        {
            var piece = Pieces
                .FirstOrDefault(p => p.Square == startSquare);

            if(piece == null)
                throw new Exception("No piece selected.");

            if(piece.Color != color)
                throw new Exception("You can't move an opponents piece.");

            piece.Move(endSquare);
        }

        public Square[,] GetSquares()
        {
            return _squares;
        }

        public Square GetSquare(int x, int y)
        {
            if ((x >= 0 & x < 8) && (y >= 0 && y < 8))
                return _squares[y, x];

            return null;
        }

        public Piece GetPieceBySquare(Square square)
        {
            return Pieces
                .FirstOrDefault(p => p.Square.Equals(square));
        }
    }
}
