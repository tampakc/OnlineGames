namespace OnlineGames.Models.User;

public class GuestUser : User
{
    public string SessionId { get; set; } = "";
}
