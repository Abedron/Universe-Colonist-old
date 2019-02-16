using System;

namespace Game.Goods.Planets
{
    public class Planet : IPlanet
    {
        public EventHandler OnComingRocket { get; }

        public void InvokeComingRocket()
        {
            
        }
    }
}