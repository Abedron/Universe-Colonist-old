using System;
using Game.Configurations;

namespace Game.Goods
{
    public interface IRaising
    {
        event EventHandler<LevelUpArgs> OnLevelUp;
        bool Enabled { get; }
        bool IsBuilt { get; }
        int Level { get; }
        bool TryRaiseLevel(int xp);
    }
}