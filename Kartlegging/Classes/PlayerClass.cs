namespace Kartleggingstest.Classes;

public class Player(string name, int level, int xp)
{
    public string   Name    { get; set; } = name;
    public int      Level   { get; set; } = level;
    public int      Xp      { get; set; } = xp;
}