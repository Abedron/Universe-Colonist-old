using System;

namespace Game.GameModel
{
    public class LevelUpArgs : EventArgs
    {
        public int OldLevel { get; }
        public int NewLevel { get; }

        public LevelUpArgs(int oldLevel, int newLevel)
        {
            OldLevel = oldLevel;
            NewLevel = newLevel;
        }
    }
}