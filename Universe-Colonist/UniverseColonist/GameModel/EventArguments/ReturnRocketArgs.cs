using Game.Articles;
using System;

namespace Game.GameModel
{
    public class ReturnRocketArgs : EventArgs
    {
        public PlanetType FromTarget { get; }

        public ReturnRocketArgs(PlanetType fromTarget)
        {
            FromTarget = fromTarget;
        }
    }
}