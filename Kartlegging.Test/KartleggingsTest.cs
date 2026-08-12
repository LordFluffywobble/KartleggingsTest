using Kartleggingstest;
using Kartlegging;
using Kartleggingstest.Classes;

namespace Kartlegging.Test;

public class UnitTest1
{
    [Fact]
    public void TestPlayer1()
    {
        var player1 = new Player("player1", 1, 0);
        var lvl = new Leveling();

        var addNoLvl    = lvl.AddXp(player1, 5);
        var addLvl      = lvl.AddXp(player1, 10);
        var addLvlAndXp = lvl.AddXp(player1, 15);

        Assert.Equal    (1, addNoLvl);
        Assert.Equal    (2, addLvl);
        Assert.Equal    (2, addLvlAndXp);
    }

    [Fact]
    public void TestPlayer2()
    {
        var player2 = new Player("player1", 4, 0);
        var lvl = new Leveling();

        var addNoLvl    = lvl.AddXp(player2, 5);
        var addLvl      = lvl.AddXp(player2, 10);
        var addLvlAndXp = lvl.AddXp(player2, 15);

        Assert.Equal    (4, addNoLvl);
        Assert.Equal    (5, addLvl);
        Assert.Equal    (5, addLvlAndXp);
    }
}
