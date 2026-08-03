using Kartleggingstest;

namespace Kartlegging.Test;

public class UnitTest1
{
    [Fact]
    public void AddXpTest()
    {
        var lvl = new LvL();
        var addNoLvl    = lvl.AddXp(5);
        var addLvl      = lvl.AddXp(10);
        var addLvlAndXp = lvl.AddXp(15);

        Assert.NotEqual (2, addNoLvl);
        Assert.Equal    (2, addLvl);
        Assert.Equal    (2, addLvlAndXp);
    }    
}
