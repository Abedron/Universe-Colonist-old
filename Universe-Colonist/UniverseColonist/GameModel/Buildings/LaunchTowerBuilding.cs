using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class LaunchTowerBuilding : StandardBuildingBase
    {
        public LaunchTowerBuilding(BuildingDataBase<ILevelUpByBaseStationDefinition> data) : base(data)
        {
        }
    }
}
