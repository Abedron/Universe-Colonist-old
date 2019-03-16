namespace Game.Services.Definitions
{
    public class BuildingDefinitionBase : IRaiseDefinition
    {
        public int BaseStationLevel { get; set; }
        public int Level { get; set; }
    }
}