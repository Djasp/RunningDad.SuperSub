namespace RunningDad.SuperSub.Models;

public class Substitution
{
    private int _seconds;
    private int _index;

    private Player PlayerIn { get; set; } = new Player();
    private Player PlayerOut { get; set; } = new Player();
    
    public Substitution(Player playerIn, Player playerOut, int seconds, int index)
    {
        PlayerIn = playerIn;
        PlayerOut = playerOut;
        _seconds = seconds;
        _index = index;
    }
    
}