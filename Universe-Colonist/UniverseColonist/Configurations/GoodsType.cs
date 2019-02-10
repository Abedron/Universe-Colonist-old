using System;

namespace Game.Configurations
{
    [Flags]
    public enum GoodsType
    {
        None,
        Player,
        BaseStation,
        LaunchTower,
        RecruitmentOfColonist,
        FuelRefinery,
        ResearchLaboratory,
        AntimatterCatcher,
        ResourceObservatory
    }
}