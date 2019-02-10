using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class BaseStationBuilding : Raising
    {
        public BaseStationBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}