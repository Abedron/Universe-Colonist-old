using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class AntimatterCatcherBuilding : StandardBuildingBase
    {
        public AntimatterCatcherBuilding(BuildingDataBase<ILevelUpByBaseStationDefinition> data) : base(data)
        {
        }
    }
}
