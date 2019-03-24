using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class LaunchTowerData<D> : StandardBuildingDataBase<D> where D : ILevelUpByBaseStationDefinition
    {
        public LaunchTowerData(D[] definitions) : base(definitions)
        {
        }
    }
}