using Chess.Core.Enums;

namespace Chess.Core
{
    public interface IPlayer
    {
        string Name { get; set; }
        PieceColor Color { get; set; }
    }
}