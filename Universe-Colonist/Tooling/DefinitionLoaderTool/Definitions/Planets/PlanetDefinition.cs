namespace Game.Services.Definitions
{
    public class PlanetDefinition : ILevelUpByBaseStationDefinition
    {
        public int BaseStationLevel { get; internal set; }
        public int Level { get; internal set; }
        public int CargoMultiplier { get; internal set; }
        public string ResourceType { get; internal set; }
        public int Count { get; internal set; }
        public int JourneyTime { get; internal set; }
        public int Coins { get; internal set; }
        public int Stars { get; internal set; }
        public int HyperMetal { get; internal set; }
        public int Ore { get; internal set; }
        public int Minerals { get; internal set; }
        public int Food { get; internal set; }
        public int Fuel { get; internal set; }
    }
}