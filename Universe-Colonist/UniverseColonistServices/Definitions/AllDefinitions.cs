namespace Game.Services.Definitions
{
    public sealed class AllDefinitions
    {
        public string Version { get; internal set; }
        public PlayerDefinition[] Player { get; internal set; }
        public BuildingsDefinitions Buildings { get; } = new BuildingsDefinitions();
        public PlanetDefinitions Planets { get; } = new PlanetDefinitions();
        public RocketDefinitions Rockets { get; } = new RocketDefinitions();
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
        public PlanetDefinition[] Antuel { get; internal set; }
        public PlanetDefinition[] Asteroids { get; internal set; }
        public PlanetDefinition[] Jupiter { get; internal set; }
        public PlanetDefinition[] Mars { get; internal set; }
        public PlanetDefinition[] Mercury { get; internal set; }
        public PlanetDefinition[] Venus { get; internal set; }
    }

    public class RocketDefinitions
    {
        public AccessRocketsDefinition[] AccessRocketsDefinitions { get; internal set; }
        public RocketDefinitionBase[] NeoV { get; internal set; }
        public RocketDefinitionBase[] BlueLight { get; internal set; }
    }
}