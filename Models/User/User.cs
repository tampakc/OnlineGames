using System.ComponentModel.DataAnnotations;

namespace OnlineGames.Models.User;

public abstract class User
{
    public int Id { get; set; }
    
    [MaxLength(50)]
    public string DisplayName { get; set; } = "";
}