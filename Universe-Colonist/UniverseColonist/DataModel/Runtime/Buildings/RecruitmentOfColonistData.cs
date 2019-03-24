using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class RecruitmentOfColonistData : BuildingDataBase
    {
        public RecruitmentOfColonistDefinition[] Definitions { get; }
        public RecruitmentOfColonistDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];
        public RecruitmentOfColonistData(RecruitmentOfColonistDefinition[] definitions)
        {
            Definitions = definitions;
        }
    }
}