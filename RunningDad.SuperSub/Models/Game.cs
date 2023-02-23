using SQLite;

namespace RunningDad.SuperSub.Models;

[Table("Game")]
public class Game
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [NotNull]
    public int TeamId { get; set; }
    
    [Ignore]
    public Team Team { get; set; } = new Team();

    [Ignore]
    public IEnumerable<Substitution> Substitutions { get; set; } = new List<Substitution>();

    public bool GameStarted { get; set; } = false;

    public DateTime StartTime { get; set; }
}