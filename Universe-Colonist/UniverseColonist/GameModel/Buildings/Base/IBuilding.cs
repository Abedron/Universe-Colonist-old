namespace Game.GameModel.Buildings
{
    public interface IBuilding
    {
        bool TryLevelUp(int dependencyLevel);
    }
}