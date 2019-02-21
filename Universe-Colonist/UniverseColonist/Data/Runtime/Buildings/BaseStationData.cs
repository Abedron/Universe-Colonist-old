using Game.Data.Storage;
using Game.Services.Definitions;

namespace Game.Data.Runtime
{
    public class BaseStationData : BuildingDataBase<BaseStationDefinition, BaseStation>
    {
        public BaseStationData(BaseStationDefinition[] definition, BaseStation baseStation) : base(definition, baseStation)
        {
        }
    }
}