using Game.Configurations;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class FuelRefineryBuilding : Raising
    {
        public FuelRefineryBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}