using Kartleggingstest;

namespace Kartlegging.Test;

public class UnitTest1
{
    [Fact]
    public void LvlOne()
    {
        var lvl = new LvL();
        var addXp = lvl.AddOneXp();
        Assert.Equal(1, addXp);
    }

    [Fact]
    public void LvlTwo()
    {
        var lvl = new LvL();
        var addLvl = lvl.AddLvl();
        Assert.True(addLvl >= 10);
    }
}
