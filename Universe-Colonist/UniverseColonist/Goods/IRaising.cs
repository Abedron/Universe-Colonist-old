using System;

namespace Game.Goods
{
    public interface IRaising
    {
        event EventHandler<LevelUpArgs> OnLevelUp;
        bool Enabled { get; }
        bool IsBuilt { get; set; }
        int Level { get; }
        bool TryRaiseLevel(int xp);
    }
}