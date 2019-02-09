using Game.Buildings;

namespace Game.Configurations.Definitions
{
    public class BuildingDefinition : ILeveling
    {
        public int Level { get; set; } = 0;
        public int RewardXp { get; set; }
    }
}