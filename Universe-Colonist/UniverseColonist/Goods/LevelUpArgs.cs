using System;

namespace Game.Goods
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