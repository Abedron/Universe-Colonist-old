using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class AntimatterCatcherBuilding : Raising
    {
        public AntimatterCatcherBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}