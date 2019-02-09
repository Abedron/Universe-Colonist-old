using Newtonsoft.Json;

namespace Game.Services
{
    public sealed class Config
    {
        [JsonProperty]
        public string Version { get; internal set; }
        [JsonProperty]
        public DefinitionPaths DefinitionPaths { get; internal set; }
    }

    public sealed class DefinitionPaths
    {
        [JsonProperty]
        public string Game { get; internal set; }
        [JsonProperty]
        public BuildingsPaths BuildingsPaths { get; internal set; }
    }

    public sealed class BuildingsPaths
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