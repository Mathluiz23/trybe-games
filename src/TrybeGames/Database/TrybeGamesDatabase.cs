namespace TrybeGames;

public class TrybeGamesDatabase
{
  public List<Game> Games = new();

  public List<GameStudio> GameStudios = new();

  public List<Player> Players = new();

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
    var games = new List<Game>();

    foreach (var game in Games)
    {
      if (game.Players.Contains(playerEntry.Id))
      {
        games.Add(game);
      }
    }

    return games;
  }

  public object GetGamesPlayedBy(int playerId)
  {
    var games = new List<Game>();

    foreach (var game in Games)
    {
      if (game.Players.Contains(playerId))
      {
        games.Add(game);
      }
    }

    return games;
  }

  public object GetGamesOwnedBy(int playerId)
  {
    var games = new List<Game>();

    foreach (var game in Games)
    {
      if (game.Players.Contains(playerId))
      {
        games.Add(game);
      }
    }

    return games;
  }

  public object GetGamesDevelopedBy(int gameStudioId)
  {
    var games = new List<Game>();

    foreach (var game in Games)
    {
      if (game.DeveloperStudio == gameStudioId)
      {
        games.Add(game);
      }
    }

    return games;
  }
}
