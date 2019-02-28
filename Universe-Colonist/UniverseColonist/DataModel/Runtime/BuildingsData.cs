namespace Game.DataModel.Runtime
{
    public class BuildingsData
    {
        public BaseStationData BaseStation { get; } = new BaseStationData();
        public AntimatterCatcherData AntimatterCatcher { get; } = new AntimatterCatcherData();
        public FuelRefineryData FuelRefinery { get; } = new FuelRefineryData();
        public LaunchTowerData LaunchTower { get; } = new LaunchTowerData();
        public RecruitmentOfColonistData RecruitmentOfColonist { get; } = new RecruitmentOfColonistData();
        public ResearchLaboratoryData ResearchLaboratory { get; } = new ResearchLaboratoryData();
        public ResourceObservatoryData ResourceObservatory { get; } = new ResourceObservatoryData();
    }
}