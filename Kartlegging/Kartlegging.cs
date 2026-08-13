using Kartleggingstest.Classes;

namespace Kartleggingstest;

public class Leveling
{
    public int AddXp(Player player, int xp)  => xp >= 10 ? player.Level + 1 : player.Level;
}