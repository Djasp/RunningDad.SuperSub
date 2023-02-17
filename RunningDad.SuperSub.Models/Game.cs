namespace RunningDad.SuperSub.Models;

public class Game
{
    public Team Team { get; set; } = new Team();
    
    public IEnumerable<Substitution> Substitutions { get; set; } = new List<Substitution>();
    
    public bool GameStarted { get; set; } = false;
    
    public DateTime StartTime { get; set; }
    
    }