using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class FuelRefineryData<T> : BuildingDataBase<T> where T : ILevelUpByBaseStationDefinition
    {
        public FuelRefineryData(T[] definitions) : base(definitions)
        {
        }
    }
}
