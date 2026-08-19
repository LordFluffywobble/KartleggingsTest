using Kartlegging.Interfaces;

public interface ITaskContext
{
    int Count {get;}
    List<IPlayerTask>GetAllPlayers();
    IPlayerTask? GetPLayerByID(int id);
    List<IPlayerTask> GetLevelUp();

    bool LeveledUp();
    bool DeletePlayer();
    IPlayerTask AddPlayer(int id, string playerName, int level, int xp);

}