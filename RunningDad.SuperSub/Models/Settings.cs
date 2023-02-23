using SQLite;

namespace RunningDad.SuperSub.Models;

[Table("Settings")]
public class Settings
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    [NotNull]
    public int NumberOfFieldPlayers { get; set; } = 11;
    [NotNull]
    public int MinutesPerGame { get; set; } = 30;
    [NotNull]
    public bool HasHalfTime { get; set; } = true;
}