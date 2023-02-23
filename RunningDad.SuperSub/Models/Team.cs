using SQLite;

namespace RunningDad.SuperSub.Models;

[Table("Team")]
public class Team
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    [MaxLength(50),NotNull, Indexed]
    public string Name { get; set; } = string.Empty;
    
    [Ignore]
    public IEnumerable<Player> Players { get; set; } = new List<Player>();
    
}