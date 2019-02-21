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
        public BuildingsPaths BuildingsPaths { get; internal set; }
    }

    internal sealed class BuildingsPaths
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
}