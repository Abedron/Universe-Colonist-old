namespace Game.Services.Definitions
{
    public class PlanetDefinitionBase : IRaiseDefinition
    {
        public string ResourceType { get; internal set; }
        public int Count { get; internal set; }
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
    }
}