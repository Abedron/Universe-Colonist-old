using Game.GameModel.Rockets;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class LaunchTowerData<T> : BuildingDataBase<T> where T : ILevelUpByBaseStationDefinition
    {
        public LaunchTowerData<T>(T[] definitions) : base(definitions)
        {
        }
    }
}