using Game.Buildings;

namespace Game.Services.Definitions.Buildings
{
    public class BuildingDefinition : ILeveling
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; } = 0;
        public string Value { get; internal set; }
    }
}