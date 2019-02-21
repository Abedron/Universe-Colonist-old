using Game.Data.Storage;
using Game.Services.Definitions;

namespace Game.Data.Runtime
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

        public BuildingsData(BuildingsDefinitions buildingsDefinitions, Buildings buildings)
        {
            BaseStation = new BaseStationData(buildingsDefinitions.BaseStation, buildings.BaseStation);
            AntimatterCatcher = new AntimatterCatcherData(buildingsDefinitions.AntimatterCatcher, buildings.AntimatterCatcher);
            FuelRefinery = new FuelRefineryData(buildingsDefinitions.FuelRefinery, buildings.FuelRefinery);
            LaunchTower = new LaunchTowerData(buildingsDefinitions.LaunchTower, buildings.LaunchTower);
            RecruitmentOfColonist = new RecruitmentOfColonistData(buildingsDefinitions.RecruitmentOfColonist, buildings.RecruitmentOfColonist);
            ResearchLaboratory = new ResearchLaboratoryData(buildingsDefinitions.ResearchLaboratory, buildings.ResearchLaboratory);
            ResourceObservatory = new ResourceObservatoryData(buildingsDefinitions.ResourceObservatory, buildings.ResourceObservatory);
        }
    }
}