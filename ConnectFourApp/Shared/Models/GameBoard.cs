namespace ConnectFourApp.Shared.Models;

public class GameBoard
{
    public GamePlayers[,] Board { get; set; }

    public GameBoard()
    {
        Board = new GamePlayers[7, 6];

        for (int i = 0; i <= 6; i++)
        {
            for (int j = 0; j <= 5; j++)
            {
                Board[i, j] = new GamePlayers(GamePlayer.None);
            }
        }
    }
}

