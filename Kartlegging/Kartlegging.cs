using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using Kartleggingstest.Classes;

namespace Kartleggingstest;

public class Leveling
{
    public int AddXp(Player player, int xp)  => xp >= 10 ? player.Level + 1 : player.Level;
}