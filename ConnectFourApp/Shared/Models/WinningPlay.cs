namespace ConnectFourApp.Shared.Models;

public class WinningPlay
{
    public List<string> WinningMoves { get; set; }

    public CheckWinPosition WinningPosition { get; set; }

    public GamePlayer WinningPlayer { get; set; }
}