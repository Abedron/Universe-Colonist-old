using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Rockets
{
    public class RocketBase<TData, TDefinition, TStorage> : RaisingBase<TDefinition, TStorage> where TDefinition : IRaiseDefinition where TStorage : IRaiseStorage
    {
        protected TData Data { get; }

        public RocketBase(TData data, TDefinition[] definitions, TStorage storage) : base(definitions, storage)
        {
            Data = data;
        }
    }
}
