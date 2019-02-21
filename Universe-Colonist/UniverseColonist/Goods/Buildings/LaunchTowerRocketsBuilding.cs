using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class LaunchTowerRocketsBuilding : Raising
    {
        public LaunchTowerRocketsBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}