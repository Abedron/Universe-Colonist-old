using Game.GameModel;
using System;

namespace Game.GameModels.Buildings
{
    public class BuildingBase<TData>
    {
        public event EventHandler<LevelUpArgs> OnLevelUp;
        protected TData Data { get; }

        public BuildingBase(TData data)
        {
            Data = data;
        }
    }
}
