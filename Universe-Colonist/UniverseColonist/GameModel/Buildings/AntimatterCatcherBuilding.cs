using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class AntimatterCatcherBuilding : StandardBuildingBase
    {
        public AntimatterCatcherBuilding(BuildingDataBase<ILevelUpByBaseStationDefinition> data) : base(data)
        {

        }

        public bool TryAddHarvester()
        {
            AntimatterCatcherData<ILevelUpByBaseStationDefinition> data = (AntimatterCatcherData <ILevelUpByBaseStationDefinition> )Data;
            
            return false;
        }
    }
}
