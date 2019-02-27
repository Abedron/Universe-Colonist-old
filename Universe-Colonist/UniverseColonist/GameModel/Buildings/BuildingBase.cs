using Game.DataModel.Storage;
using Game.Services.Definitions;
using System;

namespace Game.GameModel.Buildings
{
    public class BuildingBase<TData, TDefinition, TStorage> : Raising<TDefinition, TStorage> where TDefinition : IRaiseDefinition where TStorage : IRaiseStorage
    {
        public event EventHandler<LevelUpArgs> OnLevelUp;
        protected TData Data { get; }

        public BuildingBase(TData data, TDefinition[] definitions, TStorage storage) : base(definitions, storage)
        {
            Data = data;
        }
    }
}
