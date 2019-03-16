namespace Game.Services.Definitions
{
    public class PlanetDefinitionBase : IRaiseDefinition
    {
        public int BaseStationLevel { get; set; }
        public int Level { get; set; }
        public string CargoMultiplier { get; set; }
        public string ResourceType { get; set; }
        public int Count { get; set; }
        public int JourneyTime { get; set; }
        public int Coins { get; set; }
        public int Stars { get; set; }
        public int HyperMetal { get; set; }
        public int Ore { get; set; }
        public int Minerals { get; set; }
        public int Food { get; set; }
        public int Fuel { get; set; }
    }
}