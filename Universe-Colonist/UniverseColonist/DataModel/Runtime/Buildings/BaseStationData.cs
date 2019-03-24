using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class BaseStationData : BuildingDataBase
    {
        public BaseStationDefinition[] Definitions { get; }
        public BaseStationDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];
        public BaseStationData(BaseStationDefinition[] definitions)
        {
            Definitions = definitions;
        }
    }
}