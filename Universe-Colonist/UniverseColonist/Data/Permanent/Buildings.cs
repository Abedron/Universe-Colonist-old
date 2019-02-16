namespace Game.Data.Permanent
{
    public class Building
    {
        public BuildingBase BuildingBase { get; } = new BuildingBase();
        public AntimatterCatcher AntimatterCatcher { get; } = new AntimatterCatcher();
        public FuelRefinery FuelRefinery { get; } = new FuelRefinery();
        public LaunchTower LaunchTower { get; } = new LaunchTower();
        public RecruitmentOfColonist RecruitmentOfColonist { get; } = new RecruitmentOfColonist();
        public ResearchLaboratory ResearchLaboratory { get; } = new ResearchLaboratory();
        public ResourceObservatory ResourceObservatory { get; } = new ResourceObservatory();
    }
}