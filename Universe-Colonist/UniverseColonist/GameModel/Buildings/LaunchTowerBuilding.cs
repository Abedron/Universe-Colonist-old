using Game.Articles;
using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;
using System.Collections.Generic;
using System.Linq;

namespace Game.GameModel.Buildings
{
    public class LaunchTowerBuilding : BuildingBase<LaunchTowerData, LaunchTowerDefinition, LaunchTower>
    {
        private IList<RocketBase> flyingRockets = new List<RocketBase>();

        public LaunchTowerBuilding(LaunchTowerData data, LaunchTowerDefinition[] definitions, LaunchTower storage) : base(data, definitions, storage)
        {
        }

        public RocketBase SendRocketTo(RocketType rocketType, RocketTarget rocketTarget)
        {
            var definition = Definitions.FirstOrDefault(d => d.Level == Storage.Level);
            if (Data.NumberOfRocketFlying >= definition.FlyingRocketCount)
            {
                return RocketBase.NullRocket;
            }

            RocketBase rocket = new RocketBase(rocketType, rocketTarget);
            flyingRockets.Add(rocket);

            return rocket;
        }
    }
}
