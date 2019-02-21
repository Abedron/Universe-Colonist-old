using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class AntimatterCatcherBuilding : Raising
    {
        public AntimatterCatcherBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}