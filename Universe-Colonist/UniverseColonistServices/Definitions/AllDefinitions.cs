using Game.Services.Definitions;

namespace Game.Services
{
    public sealed class AllDefinitions
    {
        public string Version { get; internal set; }
        public IRaiseDefinition[] Game { get; internal set; }
        public Buildings Buildings { get; } = new Buildings();
    }

    public sealed class Buildings
    {
        public IRaiseDefinition[] BaseStation { get; internal set; }
        public IRaiseDefinition[] AntimatterCatcher { get; internal set; }
        public IRaiseDefinition[] FuelRefinery { get; internal set; }
        public IRaiseDefinition[] LaunchTowerRockets { get; internal set; }
        public IRaiseDefinition[] RecruitmentOfColonist { get; internal set; }
        public IRaiseDefinition[] ResearchLaboratory { get; internal set; }
        public IRaiseDefinition[] ResourceObservatory { get; internal set; }
    }
}