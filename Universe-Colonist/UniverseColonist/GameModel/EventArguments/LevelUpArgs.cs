using System;

namespace Game.GameModel
{
    public class LevelUpArgs : EventArgs
    {
        public int LevelDifference { get; }

        public LevelUpArgs(int levelDifference)
        {
            LevelDifference = levelDifference;
        }
    }
}