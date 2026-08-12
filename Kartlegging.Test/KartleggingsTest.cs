using Kartleggingstest;
using Kartlegging;
using Kartleggingstest.Classes;

namespace Kartlegging.Test;

public class UnitTest1
{
    [Fact]
    public void AddXpTest()
    {
        // var player1 = new Player("Player 1", 1, 0);
        var player2 = new Player("Player 2", 4, 0);

    
        var lvl = new Leveling();
        var addNoLvl    = lvl.AddXp(player2, 5);
        var addLvl      = lvl.AddXp(player2, 10);
        var addLvlAndXp = lvl.AddXp(player2, 15);

        Assert.NotEqual (5, addNoLvl);
        Assert.Equal    (5, addLvl);
        Assert.Equal    (5, addLvlAndXp);
    }    
}
