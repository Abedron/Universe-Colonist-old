using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class ResourceObservatoryBuilding : Raising
    {
        public ResourceObservatoryBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}