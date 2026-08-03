using Kartleggingstest;

namespace Kartlegging.Test;

public class UnitTest1
{
    [Fact]
    public void AddXpTest()
    {
        var lvl = new LvL();
        var addLvl = lvl.AddXp(10);
        Assert.Equal(2, addLvl);
    }    
}
