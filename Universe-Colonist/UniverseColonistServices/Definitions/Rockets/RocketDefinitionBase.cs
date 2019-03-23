using Game.Articles;

namespace Game.Services.Definitions
{
    public class RocketDefinitionBase : ILevelUpByBaseStationDefinition
    {
        public int BaseStationLevel { get; internal set; }
        public int Level { get; internal set; }
        public int Cargo { get; internal set; }
        public int Colonist { get; internal set; }
        public int Coins { get; internal set; }
        public int Stars { get; internal set; }
        public int HyperMetal { get; internal set; }
        public int Ore { get; internal set; }
        public int Minerals { get; internal set; }
        public int Food { get; internal set; }
        public int Fuel { get; internal set; }
    }
}