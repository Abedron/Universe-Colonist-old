using Game.GameModel;
using System;

namespace Game.DataModel.Storage
{
    public class RocketBase : IRaiseStorage
    {
        public event EventHandler<ReturnRocketArgs> OnReturnRocket;
        public int Level { get; set; }
    }
}