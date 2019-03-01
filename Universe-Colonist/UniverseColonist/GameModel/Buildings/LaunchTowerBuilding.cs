using Game.Articles;
using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.GameModel.Buildings
{
    public class LaunchTowerBuilding : BuildingBase<LaunchTowerData, LaunchTowerDefinition, LaunchTower>
    {
        public event EventHandler<ReturnRocketArgs> OnReturnRocket;
        public event EventHandler<LaunchedRocketArgs> OnLaunchedRocket;

        private IDictionary<RocketTarget, RocketBase> flyingRockets = new Dictionary<RocketTarget, RocketBase>();

        public LaunchTowerBuilding(LaunchTowerData data, LaunchTowerDefinition[] definitions, LaunchTower storage) : base(data, definitions, storage)
        {
        }

        public void SendRocketTo<TRocket>(RocketTarget rocketTarget)
        {
            var definition = Definitions.FirstOrDefault(d => d.Level == Storage.Level);
            if (Data.NumberOfRocketFlying >= definition.FlyingRocketCount)
            {
                return;
            }

            if (!flyingRockets.ContainsKey(rocketTarget))
            {
                RocketBase rocket = Activator.CreateInstance(typeof(TRocket)) as RocketBase;
                rocket.OnReturnRocket += (a, b) => OnReturnRocket.Invoke(a, b);
                flyingRockets.Add(rocketTarget, rocket);

                OnLaunchedRocket?.Invoke(this, new LaunchedRocketArgs(rocketTarget));
            }
        }
    }
}
