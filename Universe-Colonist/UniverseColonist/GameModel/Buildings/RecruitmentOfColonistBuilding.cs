using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class RecruitmentOfColonistBuilding : BuildingBase<RecruitmentOfColonistData, RecruitmentOfColonistDefinition, RecruitmentOfColonist>
    {
        public RecruitmentOfColonistBuilding(RecruitmentOfColonistData data, RecruitmentOfColonistDefinition[] definitions, RecruitmentOfColonist recruitmentOfColonist) : base(data, definitions, recruitmentOfColonist)
        {
        }
    }
}
