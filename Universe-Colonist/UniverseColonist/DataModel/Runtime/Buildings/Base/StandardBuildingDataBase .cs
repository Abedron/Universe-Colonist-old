using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class StandardBuildingDataBase<T> : BuildingDataBase<T> where T : ILevelUpByBaseStationDefinition
    {
        public StandardBuildingDataBase(T[] definitions) : base(definitions)
        {
        }
    }
}