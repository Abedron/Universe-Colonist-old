using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class AntimatterCatcherData<T> : StandardBuildingDataBase<T> where T : ILevelUpByBaseStationDefinition
    {
        public int CurrentHarvesters { get; set; }
        public AntimatterCatcherData(T[] definitions) : base(definitions)
        {
        }
    }
}
