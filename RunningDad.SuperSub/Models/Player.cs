using SQLite;

namespace RunningDad.SuperSub.Models;

[Table("Player")]
public class Player
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    [MaxLength(100), NotNull]
    public string Name { get; set; } = string.Empty;
    
    [Ignore]
    public bool IsPresent { get; set; } = false;
    [Ignore]
    public bool IsInStartingLineup { get; set; } = false;
    [Ignore]
    public bool DoNotSubstitute { get; set; } = false;
    
    [NotNull]
    public int TeamId { get; set; }
    
    [Ignore]
    public Team Team { get; set; } = new Team();
    
}