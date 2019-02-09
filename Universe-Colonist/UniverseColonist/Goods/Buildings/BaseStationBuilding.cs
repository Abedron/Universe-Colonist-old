using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class BaseStationBuilding : Raising
    {
        public BaseStationBuilding(int level, IRaiseDefinition[] buildingDefinition) : base(level, buildingDefinition)
        {
        }
    }
}