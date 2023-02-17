namespace RunningDad.SuperSub.Models;

public class Player
{
    public string Name { get; set; } = string.Empty;
    public bool IsPresent { get; set; } = false;
    public bool IsInStartingLineup { get; set; } = false;
    public bool DoNotSubstitute { get; set; } = false;
}