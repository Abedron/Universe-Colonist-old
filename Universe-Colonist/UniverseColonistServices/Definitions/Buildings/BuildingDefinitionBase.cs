namespace Game.Services.Definitions
{
    public class BuildingDefinitionBase : IBuildingDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
    }
}