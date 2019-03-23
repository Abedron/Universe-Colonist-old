using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class ResourceObservatoryBuilding : StandardBuildingBase
    {
        public ResourceObservatoryBuilding(BuildingDataBase<ILevelUpByBaseStationDefinition> data) : base(data)
        {
        }
    }
}
