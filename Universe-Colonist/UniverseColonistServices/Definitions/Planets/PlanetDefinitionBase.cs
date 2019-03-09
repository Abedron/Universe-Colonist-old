namespace Game.Services.Definitions
{
    public class PlanetDefinitionBase : IRaiseDefinition
    {
        public int AccessFromLevel { get; internal set; }
        public int Level { get; internal set; }
        public string CargoMultiplier { get; internal set; }
        public string ResourceType { get; internal set; }
        public int Count { get; internal set; }
    }
}