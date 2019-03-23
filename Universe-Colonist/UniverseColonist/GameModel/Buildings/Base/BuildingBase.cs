namespace Game.GameModel.Buildings
{
    public class BuildingBase : IBuilding
    {
        public virtual bool TryLevelUp(int dependencyLevel)
        {
            throw new System.NotImplementedException();
        }
    }
}
