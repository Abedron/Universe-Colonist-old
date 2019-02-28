using Game.DataModel.Storage;
using Game.Services.Definitions;
using System;

namespace Game.GameModel.Buildings
{
    public class PlanetBase<TData, TDefinition, TStorage> : RaisingBase<TDefinition, TStorage> where TDefinition : IRaiseDefinition where TStorage : IRaiseStorage
    {
        protected TData Data { get; }

        public PlanetBase(TData data, TDefinition[] definitions, TStorage storage) : base(definitions, storage)
        {
            Data = data;
        }
    }
}