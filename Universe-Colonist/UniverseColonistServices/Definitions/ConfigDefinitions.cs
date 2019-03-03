using Newtonsoft.Json;

namespace Game.Services.Definitions
{
    internal sealed class ConfigDefinitions
    {
        [JsonProperty]
        public string Version { get; internal set; }
        [JsonProperty]
        public DefinitionPaths DefinitionPaths { get; internal set; }
    }

    internal sealed class DefinitionPaths
    {
        [JsonProperty]
        public string Player { get; internal set; }
        [JsonProperty]
        public BuildingPaths BuildingPaths { get; internal set; }
        [JsonProperty]
        public PlanetPaths PlanetPaths { get; internal set; }
        [JsonProperty]
        public RocketPaths RocketPaths { get; internal set; }
    }

    internal sealed class BuildingPaths
    {
        [JsonProperty]
        public string BaseStation { get; internal set; }
        [JsonProperty]
        public string AntimatterCatcher { get; internal set; }
        [JsonProperty]
        public string FuelRefinery { get; internal set; }
        [JsonProperty]
        public string LaunchTower { get; internal set; }
        [JsonProperty]
        public string RecruitmentOfColonist { get; internal set; }
        [JsonProperty]
        public string ResearchLaboratory { get; internal set; }
        [JsonProperty]
        public string ResourceObservatory { get; internal set; }
    }

    internal sealed class PlanetPaths
    {
        [JsonProperty]
        public string Antuel { get; internal set; }
        [JsonProperty]
        public string Asteroids { get; internal set; }
        [JsonProperty]
        public string Jupiter { get; internal set; }
        [JsonProperty]
        public string Mars { get; internal set; }
        [JsonProperty]
        public string Mercury { get; internal set; }
        [JsonProperty]
        public string Venus { get; internal set; }
    }

    internal sealed class RocketPaths
    {
        [JsonProperty]
        public string NeoV { get; internal set; }
        [JsonProperty]
        public string BlueLight { get; internal set; }
    }
}