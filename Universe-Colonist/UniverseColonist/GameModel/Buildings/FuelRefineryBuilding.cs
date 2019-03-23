using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class FuelRefineryBuilding : StandardBuildingBase
    {
        public FuelRefineryBuilding(BuildingDataBase<ILevelUpByBaseStationDefinition> data) : base(data)
        {
        }
    }
}
