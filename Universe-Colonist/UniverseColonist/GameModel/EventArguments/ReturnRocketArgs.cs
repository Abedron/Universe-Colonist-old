using Game.Articles;
using System;

namespace Game.GameModel
{
    public class ReturnRocketArgs : EventArgs
    {
        public RocketTarget FromTarget { get; }

        public ReturnRocketArgs(RocketTarget fromTarget)
        {
            FromTarget = fromTarget;
        }
    }
}