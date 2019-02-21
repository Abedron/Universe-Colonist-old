using Game.Data.Storage;
using Game.Services.Definitions;

namespace Game.Data.Runtime
{
    public class RecruitmentOfColonistData : BuildingDataBase<RecruitmentOfColonistDefinition, RecruitmentOfColonist>
    {
        public RecruitmentOfColonistData(RecruitmentOfColonistDefinition[] definition, RecruitmentOfColonist recruitmentOfColonist) : base(definition, recruitmentOfColonist)
        {
        }
    }
}