using System;

namespace Game.GameModel.Planets
{
    public class Planet : IPlanet
    {
        public EventHandler OnComingRocket { get; }

        public void InvokeComingRocket()
        {
            
        }
    }
}