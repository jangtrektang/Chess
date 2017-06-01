using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Core
{
    public class Game
    {
        public Board Board { get; }
        public IPlayer Turn { get; set; } 
        public IList<IPlayer> Players { get; }
        public IList<Move> Moves { get; set; }

        public Game()
        {
            Board = new Board();
            Players = new List<IPlayer>();
        }

        public Game(Board board)
        {
            Board = board;
        }

        public void StartGame()
        {
            Board.SetupPieces();
        }

        public void AddPlayer(IPlayer player)
        {
            Players.Add(player);
        }

        public void DoMove(IPlayer player, Square startSquare, Square endSquare)
        {
            if (!CheckPlayersTurn(player))
                return;



            Board.MovePiece(startSquare, endSquare, player.Color);
            ChangeTurn(player);
        }

        private bool CheckPlayersTurn(IPlayer player)
        {
            return Turn.Color == player.Color;
        }

        private void ChangeTurn(IPlayer currentTurn)
        {
            var turn = Players
                .FirstOrDefault(p => p.Color != currentTurn.Color);

            if(turn == null)
                throw new Exception("Other player not found.");

            Turn = turn;
        }
    }
}
