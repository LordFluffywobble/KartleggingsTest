namespace Kartlegging.Models;

using Kartlegging.Interfaces;

public class PlayerContext : IPlayerContext
{
    private List<IPlayerTask> _tasks = [];
    
    private int _nextId;
    public int Count => _tasks.Count;

    public List<IPlayerTask> GetAllPlayers() => _tasks;
    public IPlayerTask AddPlayer(string playerName, int level, int xp)
    {
        var newTask = new PlayerTask(++_nextId, playerName, level, xp);
        _tasks.Add(newTask);
        return newTask;
    }
    public bool TriggerLevelUp(int id)
    {
        var task = _tasks.Find(t => t.Id == id);
        task?.TriggerLevelUp();
        return task is not null;
    }
public IPlayerTask?         GetPlayerByID(int id)   => _tasks.FirstOrDefault(t => t.Id == id);
public List<IPlayerTask>    GetLevelUp()            => _tasks.Where         (t => t.TriggerLevelUp()).ToList();
public bool                 DeletePlayer(int id)    => _tasks.RemoveAll     (t => t.Id == id) > 0;




}