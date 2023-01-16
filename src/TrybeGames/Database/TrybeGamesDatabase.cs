namespace TrybeGames;

public class TrybeGamesDatabase
{
  public List<Game> Games = new List<Game>();

  public List<GameStudio> GameStudios = new List<GameStudio>();

  public List<Player> Players = new List<Player>();

  public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
  {
    // implementar
    var games = new List<Game>();

    foreach (var game in Games)
    {
      if (game.DeveloperStudio == gameStudio.Id)
      {
        games.Add(game);
      }
    }

    return games;
  }

  public List<Game> GetGamesPlayedBy(Player player)
  {
    var games = new List<Game>();

    foreach (var game in Games)
    {
      if (game.Players.Contains(player.Id))
      {
        games.Add(game);
      }
    }

    return games;
  }

  public List<Game> GetGamesOwnedBy(Player playerEntry)
  {
    // Implementar
    throw new NotImplementedException();
  }
}
