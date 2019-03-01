using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class ResourceObservatoryBuilding : BuildingBase<ResourceObservatoryData, ResourceObservatoryDefinition, ResourceObservatory>
    {
        public ResourceObservatoryBuilding(ResourceObservatoryData data, ResourceObservatoryDefinition[] definitions, ResourceObservatory storage) : base(data, definitions, storage)
        {
        }
    }
}
