namespace Game.Services.Definitions
{
    public class BuildingDefinitionBase : IRaiseDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
    }
}