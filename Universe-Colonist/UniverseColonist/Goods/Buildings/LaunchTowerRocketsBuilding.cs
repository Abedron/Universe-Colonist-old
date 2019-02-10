using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class LaunchTowerRocketsBuilding : Raising
    {
        public LaunchTowerRocketsBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}