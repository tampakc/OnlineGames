using System.ComponentModel.DataAnnotations;

namespace OnlineGames.Models.User;

public class UserCredentials
{
    public int Id { get; set; }
    
    public required User User { get; set; } = null!;
    
    [MaxLength(150)]
    public string PasswordHash { get; set; } = "";

    public DateTime PasswordLastChanged { get; set; }
}
