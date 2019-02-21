using Game.Data.Storage;
using Game.Services.Definitions;

namespace Game.Data.Runtime
{
    public class ResourceObservatoryData : BuildingDataBase<ResourceObservatoryDefinition, ResourceObservatory>
    {
        public ResourceObservatoryData(ResourceObservatoryDefinition[] definition, ResourceObservatory resourceObservatory) : base(definition, resourceObservatory)
        {
        }
    }
}