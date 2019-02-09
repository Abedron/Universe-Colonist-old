using System;

namespace Game.Configurations
{
    [Flags]
    public enum GoodsType
    {
        None = 0,
        Game = 1,
        BaseStation = 2,
        LaunchTower = 4,
        RecruitmentOfColonist = 8,
        FuelRefinery = 16,
        ResearchLaboratory = 32,
        AntimatterCatcher = 64,
        ResourceObservatory = 128
    }
}