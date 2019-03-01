using System;

namespace Game.GameModel
{
    public interface IRaising
    {
        event EventHandler<LevelUpArgs> OnLevelUp;
        bool TryRaiseLevel(int xp);
    }
}