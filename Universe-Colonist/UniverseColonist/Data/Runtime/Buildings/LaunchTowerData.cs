using Game.Data.Storage;
using Game.Services.Definitions;

namespace Game.Data.Runtime
{
    public class LaunchTowerData : BuildingDataBase<LaunchTowerDefinition, LaunchTower>
    {
        public LaunchTowerData(LaunchTowerDefinition[] definition, LaunchTower launchTower) : base(definition, launchTower)
        {
        }
    }
}