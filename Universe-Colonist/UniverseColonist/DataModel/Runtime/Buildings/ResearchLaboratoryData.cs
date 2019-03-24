using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class ResearchLaboratoryData<T> : StandardBuildingDataBase<T> where T : ILevelUpByBaseStationDefinition
    {
        public ResearchLaboratoryData(T[] definitions) : base(definitions)
        {
        }
    }
}