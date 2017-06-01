using System.Collections.Generic;
using System.Linq;
using Chess.Core;
using Chess.Tests.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Tests.Pieces
{
    [TestClass()]
    public class RookTests
    {
        [TestMethod()]
        public void GetPossibleMovesRookTest()
        {
            // Get board
            var board = new Board();
            board.SetupPieces();

            // Get piece
            var piece = board.Pieces
                .FirstOrDefault(p => p.Square.X == 0 && p.Square.Y == 0);

            if (piece == null)
                Assert.Fail();

            var pawn = board.Pieces
                .FirstOrDefault(p => p.Square.X == 0 && p.Square.Y == 1);

            if (pawn == null)
                Assert.Fail();

            board.MovePiece(pawn.Square, board.GetSquare(0, 3), pawn.Color);

            var moves = piece.GetPossibleMoves(board).ToList();
            var possibleMoves = new List<Move>()
            {
                new Move(piece.Square, board.GetSquare(0, 1)),
                new Move(piece.Square, board.GetSquare(0, 3))
            };
            
            CollectionAssert.AreEqual(possibleMoves, moves, new MoveComparer());
        }
    }
}