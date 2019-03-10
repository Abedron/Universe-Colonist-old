using Game.Articles;
using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.GameModel.Rockets;
using Game.Services.Definitions;
using System.Linq;

namespace Game.GameModel.Buildings
{
    public class LaunchTowerBuilding //: BuildingBase<LaunchTowerData, LaunchTowerDefinition, LaunchTower>
    {
        public LaunchTowerData Data { get; }
        public LaunchTowerDefinition[] Definitions { get; }

        public LaunchTowerBuilding(LaunchTowerData data, LaunchTowerDefinition[] definitions)
        {
            Data = data;
            Definitions = definitions;
        }

        public bool TryRaiseLevel(int baseStationLevel)
        {
            var definition = Definitions.LastOrDefault(d => d.BaseStationLevel <= baseStationLevel) ?? Definitions[0];
            bool isRaisedLevel = definition.Level != Data.Level;

            Data.Level = definition.Level;

            return isRaisedLevel;
        }

        public RocketBase SendRocketTo(RocketType rocketType, RocketTarget rocketTarget)
        {
            var definition = Definitions.FirstOrDefault(d => d.Level == Data.Level);
            if (Data.FlyingRockets.Count >= definition.FlyingRocketCount)
            {
                return RocketBase.NullRocket;
            }

            RocketModel rocket = new RocketModel(rocketType, rocketTarget);
            Data.FlyingRockets.Add(rocket);

            return rocket;
        }
    }
}
