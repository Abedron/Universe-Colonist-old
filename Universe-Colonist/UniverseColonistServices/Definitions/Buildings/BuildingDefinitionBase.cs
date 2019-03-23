namespace Game.Services.Definitions
{
    public class BuildingDefinitionBase : ILevelUpByBaseStationDefinition, ILevelUpDefinition
    {
        public int Level { get; internal set; }
        public int BaseStationLevel { get; internal set; }
    }
}