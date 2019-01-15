using System.Linq;
using Game.Configurations;

namespace Game.Buildings
{
    public class BaseStation
    {
        public int Level => 1;

        private readonly ProgressDefinition[] progressDefinition;
        private readonly BuildingDefinition[] buildingDefinition;

        public BaseStation(ProgressDefinition[] progressDefinition, BuildingDefinition[] buildingDefinition)
        {
            this.progressDefinition = progressDefinition;
            this.buildingDefinition = buildingDefinition;
        }

        public bool TryRaiseLevel(int xp)
        {
            BuildingDefinition buildingDefinition = this.buildingDefinition.FirstOrDefault(d => d.RewardXp < xp);

            return false;
        }
    }
}