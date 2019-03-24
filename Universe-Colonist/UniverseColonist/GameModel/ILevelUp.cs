namespace Game.GameModel
{
    public interface ILevelUp
    {
        bool TryLevelUp(int dependencyLevel);
    }
}