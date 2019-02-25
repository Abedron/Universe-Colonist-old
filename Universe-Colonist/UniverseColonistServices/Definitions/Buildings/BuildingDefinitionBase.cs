namespace Game.Services.Definitions
{
    public class BuildingDefinitionBase : IRaisingDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
    }
}