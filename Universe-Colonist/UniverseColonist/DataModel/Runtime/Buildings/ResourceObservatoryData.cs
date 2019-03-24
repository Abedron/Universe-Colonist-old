using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class ResourceObservatoryData : BuildingDataBase
    {
        public ResourceObservatoryDefinition[] Definitions { get; }
        public ResourceObservatoryDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];
        public ResourceObservatoryData(ResourceObservatoryDefinition[] definitions)
        {
            Definitions = definitions;
        }
    }
}