namespace Game.Services.Definitions
{
    public class PlanetDefinitionBase : IRaiseDefinition
    {
        public int AccessFromLevel { get; set; }
        public int Level { get; set; }
        public string CargoMultiplier { get; set; }
        public string ResourceType { get; set; }
        public int Count { get; set; }
    }
}