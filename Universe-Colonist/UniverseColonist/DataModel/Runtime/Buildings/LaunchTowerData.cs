using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class LaunchTowerData : BuildingDataBase<LaunchTowerDefinition, LaunchTower>
    {
        public LaunchTowerData(LaunchTowerDefinition[] definition, LaunchTower launchTower) : base(definition, launchTower)
        {
        }
    }
}