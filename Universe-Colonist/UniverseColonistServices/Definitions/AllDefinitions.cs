namespace Game.Services.Definitions
{
    public sealed class AllDefinitions
    {
        public string Version { get; internal set; }
        public PlayerDefinition[] Player { get; internal set; }
        public Buildings Buildings { get; } = new Buildings();
    }

    public sealed class Buildings
    {
        public BaseStationDefinition[] BaseStation { get; internal set; }
        public AntimatterCatcherDefinition[] AntimatterCatcher { get; internal set; }
        public FuelRefineryDefinition[] FuelRefinery { get; internal set; }
        public LaunchTowerRocketsDefinition[] LaunchTowerRockets { get; internal set; }
        public RecruitmentOfColonistDefinition[] RecruitmentOfColonist { get; internal set; }
        public ResearchLaboratoryDefinition[] ResearchLaboratory { get; internal set; }
        public ResourceObservatoryDefinition[] ResourceObservatory { get; internal set; }
    }
}