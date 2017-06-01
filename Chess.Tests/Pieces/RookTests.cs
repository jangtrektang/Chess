using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess.Core.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Pieces.Tests
{
    [TestClass()]
    public class RookTests
    {
        [TestMethod()]
        public void GetPossibleMovesRookTest()
        {
            // Start game
            var game = new Game();
            game.StartGame();

            // Get piece
            var piece = game.Board.Pieces
                .FirstOrDefault(p => p.Square.X == 0 && p.Square.Y == 0);


        }
    }
}