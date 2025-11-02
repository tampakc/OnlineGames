namespace OnlineGames.Models.Game.GameStates.Impostor;

public class ImpostorGame : Game
{
    public override GameType GameType => GameType.ImpostorGame;

    public override ImpostorGameState GameState { get; } = new();
}