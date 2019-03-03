namespace Game.Services.Definitions
{
    public sealed class AllDefinitions
    {
        public string Version { get; set; }
        public PlayerDefinition[] Player { get; set; }
        public BuildingsDefinitions Buildings { get; } = new BuildingsDefinitions();
        public PlanetDefinitions Planets { get; } = new PlanetDefinitions();
        public RocketDefinitions Rockets { get; } = new RocketDefinitions();
    }

    public sealed class BuildingsDefinitions
    {
        public BaseStationDefinition[] BaseStation { get; set; }
        public AntimatterCatcherDefinition[] AntimatterCatcher { get; set; }
        public FuelRefineryDefinition[] FuelRefinery { get; set; }
        public LaunchTowerDefinition[] LaunchTower { get; set; }
        public RecruitmentOfColonistDefinition[] RecruitmentOfColonist { get; set; }
        public ResearchLaboratoryDefinition[] ResearchLaboratory { get; set; }
        public ResourceObservatoryDefinition[] ResourceObservatory { get; set; }
    }

    public sealed class PlanetDefinitions
    {
        public AntuelDefinition[] Antuel { get; set; }
        public AsteroidsDefinition[] Asteroids { get; set; }
        public JupiterDefinition[] Jupiter { get; set; }
        public MarsDefinition[] Mars { get; set; }
        public MercuryDefinition[] Mercury { get; set; }
        public VenusDefinition[] Venus { get; set; }
    }

    public class RocketDefinitions
    {
        public NeoVDefinition[] NeoV { get; set; }
        public BlueLightDefinition[] BlueLight { get; set; }
    }
}