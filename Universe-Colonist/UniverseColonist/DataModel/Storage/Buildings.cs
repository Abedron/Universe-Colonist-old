namespace Game.DataModel.Storage
{
    public class Buildings
    {
        public BaseStation BaseStation { get; } = new BaseStation();
        public AntimatterCatcher AntimatterCatcher { get; } = new AntimatterCatcher();
        public FuelRefinery FuelRefinery { get; } = new FuelRefinery();
        public LaunchTower LaunchTower { get; } = new LaunchTower();
        public RecruitmentOfColonist RecruitmentOfColonist { get; } = new RecruitmentOfColonist();
        public ResearchLaboratory ResearchLaboratory { get; } = new ResearchLaboratory();
        public ResourceObservatory ResourceObservatory { get; } = new ResourceObservatory();
    }
}