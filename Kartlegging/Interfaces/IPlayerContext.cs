using Kartlegging.Interfaces;

public interface IPlayerContext
{
    int Count {get;}
    List<IPlayerTask>GetAllPlayers();
    IPlayerTask? GetPlayerByID(int id);
    List<IPlayerTask> GetLevelUp();

    bool TriggerLevelUp(int id);
    bool DeletePlayer(int id);
    IPlayerTask AddPlayer(string playerName, int level, int xp);

}