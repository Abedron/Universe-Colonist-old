using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class RecruitmentOfColonistData : BuildingDataBase<RecruitmentOfColonistDefinition, RecruitmentOfColonist>
    {
        public RecruitmentOfColonistData(RecruitmentOfColonistDefinition[] definition, RecruitmentOfColonist recruitmentOfColonist) : base(definition, recruitmentOfColonist)
        {
        }
    }
}