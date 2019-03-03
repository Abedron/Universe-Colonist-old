namespace Game.Services.Definitions
{
    public class RocketDefinitionBase : IRaiseDefinition
    {
        public int Xp { get; set; }
        public int Level { get; set; }
        public int MaxCount { get; set; }
        public int HyperMetal { get; set; }
        public int Fuel { get; set; }
        public int Ore { get; set; }
        public int Minerals { get; set; }
        public int Food { get; set; }
        public int Colonist { get; set; }
    }
}