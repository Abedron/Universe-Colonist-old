using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class LaunchTowerRocketsBuilding : Raising
    {
        public LaunchTowerRocketsBuilding(int level, IRaiseDefinition[] buildingDefinition) : base(level, buildingDefinition)
        {
        }
    }
}