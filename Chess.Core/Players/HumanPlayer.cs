using Chess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Players
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }

        public HumanPlayer()
        {

        }

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public HumanPlayer(string name, PieceColor color)
            : this(name)
        {
            Color = Color;
        }
    }
}
