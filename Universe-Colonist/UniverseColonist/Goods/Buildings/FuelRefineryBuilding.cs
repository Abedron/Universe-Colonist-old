using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class FuelRefineryBuilding : Raising
    {
        public FuelRefineryBuilding(int level, IRaiseDefinition[] buildingDefinition) : base(level, buildingDefinition)
        {
        }
    }
}