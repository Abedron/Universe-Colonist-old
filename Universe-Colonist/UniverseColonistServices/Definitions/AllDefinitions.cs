namespace Game.Services.Definitions
{
    public sealed class AllDefinitions
    {
        public string Version { get; internal set; }
        public PlayerDefinition[] Player { get; internal set; }
        public BuildingsDefinitions Buildings { get; } = new BuildingsDefinitions();
        public PlanetDefinitions Planets { get; } = new PlanetDefinitions();
    }

    public sealed class BuildingsDefinitions
    {
        public BaseStationDefinition[] BaseStation { get; internal set; }
        public AntimatterCatcherDefinition[] AntimatterCatcher { get; internal set; }
        public FuelRefineryDefinition[] FuelRefinery { get; internal set; }
        public LaunchTowerDefinition[] LaunchTower { get; internal set; }
        public RecruitmentOfColonistDefinition[] RecruitmentOfColonist { get; internal set; }
        public ResearchLaboratoryDefinition[] ResearchLaboratory { get; internal set; }
        public ResourceObservatoryDefinition[] ResourceObservatory { get; internal set; }
    }

    public sealed class PlanetDefinitions
    {
        public AntuelDefinition[] Antuel { get; internal set; }
        public AsteroidsDefinition[] Asteroids { get; internal set; }
        public JupiterDefinition[] Jupiter { get; internal set; }
        public MarsDefinition[] Mars { get; internal set; }
        public MercuryDefinition[] Mercury { get; internal set; }
        public VenusDefinition[] Venus { get; internal set; }
    }
}