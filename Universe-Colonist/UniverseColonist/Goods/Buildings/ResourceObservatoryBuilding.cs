using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class ResourceObservatoryBuilding : Raising
    {
        public ResourceObservatoryBuilding(int level, IRaiseDefinition[] buildingDefinition) : base(level, buildingDefinition)
        {
        }
    }
}