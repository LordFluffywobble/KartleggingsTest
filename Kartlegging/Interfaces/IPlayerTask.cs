namespace Kartlegging.Interfaces;

public interface IPlayerTask
{
    int Id {get; init;}
    string PlayerName {get;set;}
    int Level {get;set;}
    int Xp {get;set;}
    bool TriggerLevelUp();
}