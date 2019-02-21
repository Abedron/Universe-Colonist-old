using System;

namespace Game.GameModel.Planets
{
    public interface IPlanet
    {
        EventHandler OnComingRocket { get; }
        void InvokeComingRocket();
    }
}