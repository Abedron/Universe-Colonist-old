using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class ResourceObservatoryData : BuildingDataBase<ResourceObservatoryDefinition, ResourceObservatory>
    {
        public ResourceObservatoryData(ResourceObservatoryDefinition[] definition, ResourceObservatory resourceObservatory) : base(definition, resourceObservatory)
        {
        }
    }
}