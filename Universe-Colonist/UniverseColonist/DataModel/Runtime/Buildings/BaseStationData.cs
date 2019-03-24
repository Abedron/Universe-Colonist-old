using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class BaseStationData<T> : BuildingDataBase<T> where T : ILevelUpByPlayerDefinition
    {
        public BaseStationData(T[] definitions):base(definitions)
        {
        }
    }
}