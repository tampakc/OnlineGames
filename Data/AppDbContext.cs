using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Microsoft.EntityFrameworkCore;
using OnlineGames.Models.Game;
using OnlineGames.Models.Game.GameStates.Impostor;
using OnlineGames.Models.User;

namespace OnlineGames.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Game> Games => Set<Game>();
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = false,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver()
        };
        
        modelBuilder.Entity<User>()
            .HasDiscriminator<string>("UserType")
            .HasValue<RegisteredUser>("Registered")
            .HasValue<GuestUser>("Guest");
        
        modelBuilder.Entity<Game>()
            .HasMany(g => g.Players)
            .WithMany()
            .UsingEntity(j => j.ToTable("GamePlayers"));

        modelBuilder.Entity<ImpostorGame>()
            .Property(g => g.GameState)
            .HasConversion(
                v => JsonSerializer.Serialize(v, options),
                v => JsonSerializer.Deserialize<ImpostorGameState>(v, options)!);
    }
}