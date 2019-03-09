namespace Game.Services.Definitions
{
    public class BuildingDefinitionBase : IRaiseDefinition
    {
        public int AccessFromLevel { get; set; }
        public int Level { get; set; }
    }
}