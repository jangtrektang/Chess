using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public struct  Square
    {
        public int X { get; }
        public int Y { get; }

        public Square(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            return letters[Y] + X.ToString();
        }

        public override bool Equals(object obj)
        {
            var square = (Square)obj;

            if (square.X == X && square.Y == Y)
                return true;

            return false;
        }
    }
}
