using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class RecruitmentOfColonistData<T> : StandardBuildingDataBase<T> where T : ILevelUpByBaseStationDefinition
    {
        public RecruitmentOfColonistData(T[] definitions) : base(definitions)
        {
        }
    }
}