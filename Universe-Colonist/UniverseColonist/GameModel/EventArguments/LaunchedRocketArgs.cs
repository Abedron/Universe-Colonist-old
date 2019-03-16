using Game.Articles;
using System;

namespace Game.GameModel
{
    public class LaunchedRocketArgs : EventArgs
    {
        public PlanetType RocketTarget { get; }

        public LaunchedRocketArgs(PlanetType rocketTarget)
        {
            RocketTarget = rocketTarget;
        }
    }
}