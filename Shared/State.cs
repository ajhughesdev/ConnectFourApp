namespace ConnectFourApp.Shared;

public class State
{

  public int CurrentPlayer => GameBoard.Count(x => x != 0) % 2 + 1;

  public int CurrentTurn { get { return GameBoard.Count(x => x != 0); } }

  public byte PlayPiece(int column)
  {
    var playedCell = column;
    for (var i = column; i < 42; i += 7)
    {
      if (GameBoard[playedCell + 7] != 0) break;
      playedCell = i;
    }

    GameBoard[playedCell] = CurrentPlayer;

    return ConvertPlayedCellToRow(playedCell);

  }

  public List<int> GameBoard { get; private set; } = new List<int>(new int[42]);

  private byte ConvertPlayedCellToRow(int playedCell) => (byte)(Math.Floor(playedCell / (decimal)7) + 1);

}