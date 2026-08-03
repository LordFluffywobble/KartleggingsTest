using System.Reflection;

namespace Kartleggingstest;


public class LvL
{
    int level = 1;

    public int AddOneXp()   => 1;

    public int AddXp(int a) => a >= 10 ? level + 1 : level;
 
}