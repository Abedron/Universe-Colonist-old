using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModels.Buildings
{
    public class BaseStationBuilding : BuildingBase<BaseStationData, BaseStationDefinition, BaseStation>
    {
        public BaseStationBuilding(BaseStationData data, BaseStationDefinition[] definitions, BaseStation baseStation) : base(data, definitions, baseStation)
        {
        }
    }
}
