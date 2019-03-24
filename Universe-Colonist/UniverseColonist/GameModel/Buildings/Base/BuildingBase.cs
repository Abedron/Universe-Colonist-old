namespace Game.GameModel.Buildings
{
    public class BuildingBase : ILevelUp
    {
        public virtual bool TryLevelUp(int dependencyLevel)
        {
            throw new System.NotImplementedException();
        }
    }
}
