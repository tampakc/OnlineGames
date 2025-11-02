namespace OnlineGames.Models.Game.GameStates.Impostor;

public class ImpostorGameState : IGameState
{
    User.User? ImpostorUser { get; set; }

    public string SecretWord { get; private set; } = "";
    
    public int Round { get; private set; } = 0;
    
    public int TotalRounds { get; private set; } = 4;
    
    public Dictionary<User.User, int> PlayerPoints  { get; set; } = new();
}