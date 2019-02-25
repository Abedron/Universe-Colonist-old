using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModels.Buildings
{
    public class LaunchTowerBuilding : BuildingBase<LaunchTowerData, LaunchTowerDefinition, LaunchTower>
    {
        public LaunchTowerBuilding(LaunchTowerData data, LaunchTowerDefinition[] definitions, LaunchTower launchTower) : base(data, definitions, launchTower)
        {
        }
    }
}
