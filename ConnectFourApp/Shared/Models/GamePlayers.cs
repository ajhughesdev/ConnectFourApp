namespace ConnectFourApp.Shared.Models;

public class GamePlayers
{
    public GamePlayer Player;
    public GamePlayers() => Player = GamePlayer.None;
    public GamePlayers(GamePlayer player) => Player = player;
}