using Newtonsoft.Json;

namespace Game.Services.Definitions
{
    sealed class ConfigDefinitions
    {
        [JsonProperty]
        public string Version { get; set; }
        [JsonProperty]
        public DefinitionPaths DefinitionPaths { get; set; }
    }

    sealed class DefinitionPaths
    {
        [JsonProperty]
        public string Player { get; set; }
        [JsonProperty]
        public BuildingPaths BuildingPaths { get; set; }
        [JsonProperty]
        public PlanetPaths PlanetPaths { get; set; }
        [JsonProperty]
        public RocketPaths RocketPaths { get; set; }
    }

    sealed class BuildingPaths
    {
        [JsonProperty]
        public string BaseStation { get; set; }
        [JsonProperty]
        public string AntimatterCatcher { get; set; }
        [JsonProperty]
        public string FuelRefinery { get; set; }
        [JsonProperty]
        public string LaunchTower { get; set; }
        [JsonProperty]
        public string RecruitmentOfColonist { get; set; }
        [JsonProperty]
        public string ResearchLaboratory { get; set; }
        [JsonProperty]
        public string ResourceObservatory { get; set; }
    }

    sealed class PlanetPaths
    {
        [JsonProperty]
        public string Antuel { get; set; }
        [JsonProperty]
        public string Asteroids { get; set; }
        [JsonProperty]
        public string Jupiter { get; set; }
        [JsonProperty]
        public string Mars { get; set; }
        [JsonProperty]
        public string Mercury { get; set; }
        [JsonProperty]
        public string Venus { get; set; }
    }

    sealed class RocketPaths
    {
        [JsonProperty]
        public string NeoV { get; set; }
        [JsonProperty]
        public string BlueLight { get; set; }
    }
}