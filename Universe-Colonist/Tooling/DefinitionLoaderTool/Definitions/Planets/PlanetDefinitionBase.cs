namespace Game.Services.Definitions
{
    public class PlanetDefinitionBase : IRaiseDefinition
    {
        public string ResourceType { get; set; }
        public int Count { get; set; }
        public int Xp { get; set; }
        public int Level { get; set; }
    }
}