using System.Collections.Generic;

namespace Chess.Core
{
    public class Game
    {
        public Board Board { get; }
        public IPlayer Turn { get; } 
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

        private void ChangeTurn()
        {
             
        }
    }
}
