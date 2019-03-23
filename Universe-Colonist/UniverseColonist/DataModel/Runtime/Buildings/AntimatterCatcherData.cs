using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class AntimatterCatcherData<T> : BuildingDataBase<T> where T : ILevelUpByBaseStationDefinition
    {
        public AntimatterCatcherData(T[] definitions) : base(definitions)
        {
        }
    }
}
