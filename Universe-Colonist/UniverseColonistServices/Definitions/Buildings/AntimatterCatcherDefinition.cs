namespace Game.Services.Definitions
{
    public class AntimatterCatcherDefinition : BuildingDefinitionBase
    {
        public int HarvesterCount { get; internal set; }
        public int EarningTime { get; internal set; }
        public int Resources { get; internal set; }
    }
}