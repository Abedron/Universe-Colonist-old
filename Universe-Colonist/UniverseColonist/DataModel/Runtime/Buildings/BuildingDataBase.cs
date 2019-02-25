using Game.DataModel.Storage;
using Game.GameModel;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class BuildingDataBase<TDefinition, TStorage> : Raising<TDefinition, TStorage> where TDefinition : IRaisingDefinition where TStorage : IRaisingStorage
    {
        public bool IsActivate { get; set; }
        public BuildingDataBase(TDefinition[] definitions, TStorage storage):base(definitions, storage)
        {
        }
    }
}