namespace Kartlegging.Models;

using Kartlegging.Interfaces;

public class PlayerTask(int id,string playerName, int level, int xp) //: IPlayerTask
{
    public int Id {get; init;} = id;
    public string PlayerName {get;set;} = playerName;
    public int Level {get;set;} = level;
    public int Xp {get;set;} = xp;
    //public bool GetLevelUp() => getLevelUp = true;
}