using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class BuildingsData
    {
        public BaseStationData BaseStation { get; }
        public AntimatterCatcherData AntimatterCatcher { get; }
        public FuelRefineryData FuelRefinery { get; }
        public LaunchTowerData LaunchTower { get; }
        public RecruitmentOfColonistData RecruitmentOfColonist { get; }
        public ResearchLaboratoryData ResearchLaboratory { get; }
        public ResourceObservatoryData ResourceObservatory { get; }

        public BuildingsData()
        {
            BaseStation = new BaseStationData();
            AntimatterCatcher = new AntimatterCatcherData();
            FuelRefinery = new FuelRefineryData();
            LaunchTower = new LaunchTowerData();
            RecruitmentOfColonist = new RecruitmentOfColonistData();
            ResearchLaboratory = new ResearchLaboratoryData();
            ResourceObservatory = new ResourceObservatoryData();
        }
    }
}