using System.ComponentModel.DataAnnotations;

namespace OnlineGames.Models.User;

public class RegisteredUser : User
{
    [MaxLength(50)]
    public string Email { get; set; } = "";
}
