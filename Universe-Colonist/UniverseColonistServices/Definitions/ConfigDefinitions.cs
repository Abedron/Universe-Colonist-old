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
        public BuildingPaths PlanetPaths { get; internal set; }
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
        public string LaunchTowerRockets { get; internal set; }
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
        public string AntuelDefinition { get; internal set; }
        [JsonProperty]
        public string AsteroidsDefinition { get; internal set; }
        [JsonProperty]
        public string JupiterDefinition { get; internal set; }
        [JsonProperty]
        public string MarsDefinition { get; internal set; }
        [JsonProperty]
        public string MercuryDefinition { get; internal set; }
        [JsonProperty]
        public string VenusDefinition { get; internal set; }
    }
}