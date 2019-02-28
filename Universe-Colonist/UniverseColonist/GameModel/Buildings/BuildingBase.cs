using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class BuildingBase<TData, TDefinition, TStorage> : RaisingBase<TDefinition, TStorage> where TDefinition : IRaiseDefinition where TStorage : IRaiseStorage
    {
        protected TData Data { get; }

        public BuildingBase(TData data, TDefinition[] definitions, TStorage storage) : base(definitions, storage)
        {
            Data = data;
        }
    }
}
