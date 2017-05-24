namespace Chess.Core
{
    public class Square
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

            return letters[X] + Y.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var square = (Square)obj;

            return square.X == X && square.Y == Y;
        }

        public bool Equals(Square other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}
