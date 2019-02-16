using System;

namespace Game.Goods.Planets
{
    public interface IPlanet
    {
        EventHandler OnComingRocket { get; }
        void InvokeComingRocket();
    }
}