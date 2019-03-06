namespace Game.Services.Definitions
{
    public class RocketDefinitionBase : IRaiseDefinition
    {
        public int Level { get; set; }
        public int Cargo { get; set; }
        public int Colonist { get; set; }
        public int HyperMetal { get; set; }
        public int Fuel { get; set; }
        public int Ore { get; set; }
        public int Minerals { get; set; }
        public int Food { get; set; }
    }
}