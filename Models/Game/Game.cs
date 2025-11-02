using System.ComponentModel.DataAnnotations;

namespace OnlineGames.Models.Game;

public abstract class Game
{
    public int Id { get; set; }
    
    public abstract GameType GameType { get; }
    
    [MaxLength(50)]
    public string LobbyName { get; set; } = "";
    
    public GameStatus Status { get; set; }
    
    [Required]
    public IEnumerable<User.User> Players { get; set; } = new List<User.User>();
    
    [Required]
    public abstract IGameState GameState { get; }
}