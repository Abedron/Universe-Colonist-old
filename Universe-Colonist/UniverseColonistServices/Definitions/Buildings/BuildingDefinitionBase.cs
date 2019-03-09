namespace Game.Services.Definitions
{
    public class BuildingDefinitionBase : IRaiseDefinition
    {
        public int AccessFromLevel { get; internal set; }
        public int Level { get; internal set; }
    }
}