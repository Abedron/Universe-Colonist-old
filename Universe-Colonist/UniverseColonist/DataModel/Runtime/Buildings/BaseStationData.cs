using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class BaseStationData : BuildingDataBase<BaseStationDefinition, BaseStation>
    {
        public BaseStationData(BaseStationDefinition[] definition, BaseStation baseStation) : base(definition, baseStation)
        {
        }
    }
}