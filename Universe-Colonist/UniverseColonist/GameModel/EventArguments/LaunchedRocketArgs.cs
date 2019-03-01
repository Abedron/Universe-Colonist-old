using Game.Articles;
using System;

namespace Game.GameModel
{
    public class LaunchedRocketArgs : EventArgs
    {
        public RocketTarget RocketTarget { get; }

        public LaunchedRocketArgs(RocketTarget rocketTarget)
        {
            RocketTarget = rocketTarget;
        }
    }
}