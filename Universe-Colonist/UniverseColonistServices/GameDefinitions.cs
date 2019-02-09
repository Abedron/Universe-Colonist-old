using Game.Services.Definitions;
using Game.Services.Definitions.Buildings;

namespace Game.Services
{
    public sealed class GameDefinitions
    {
        public Game[] Game { get; internal set; }
        public Buildings Buildings { get; } = new Buildings();
    }

    public sealed class Buildings
    {
        public BaseStation[] BaseStation { get; internal set; }
        public AntimatterCatcher[] AntimatterCatcher { get; internal set; }
        public FuelRefinery[] FuelRefinery { get; internal set; }
        public LaunchTowerRockets[] LaunchTowerRockets { get; internal set; }
        public RecruitmentOfColonist[] RecruitmentOfColonist { get; internal set; }
        public ResearchLaboratory[] ResearchLaboratory { get; internal set; }
        public ResourceObservatory[] ResourceObservatory { get; internal set; }
    }
}