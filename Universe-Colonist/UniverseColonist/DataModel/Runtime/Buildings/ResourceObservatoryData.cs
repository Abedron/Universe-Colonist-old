using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class ResourceObservatoryData<T> : StandardBuildingDataBase<T> where T : ILevelUpByBaseStationDefinition
    {
        public ResourceObservatoryData(T[] definitions) : base(definitions)
        {
        }
    }
}