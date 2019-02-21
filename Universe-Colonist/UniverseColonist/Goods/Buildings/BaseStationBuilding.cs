using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class BaseStationBuilding : Raising
    {
        public BaseStationBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}