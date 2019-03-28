using Game.Articles;
using Game.GameModel.Buildings;
using Game.Services.Definitions;
using System.Collections.Generic;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class RocketsOrganizer
    {
        private IList<RocketModel> Rockets { get; }
        public PlayerData PlayerData { get; }
        public LaunchTowerData LaunchTowerData { get; }
        public RocketDefinitions RocketDefinitions { get; }

        public RocketsOrganizer(IList<RocketModel> rockets,
            PlayerData playerData,
            LaunchTowerData launchTowerData,
            RocketDefinitions rocketDefinitions)
        {
            Rockets = rockets;
            PlayerData = playerData;
            LaunchTowerData = launchTowerData;
            RocketDefinitions = rocketDefinitions;
        }

        public bool TryAddRocket(RocketType rocketType)
        {
            if (Rockets.Count >= LaunchTowerData.Definition.Capacity)
                return false;

            var accessRocket = RocketDefinitions.AccessRocketsDefinitions.FirstOrDefault(d => d.RocketType == rocketType.ToString());
            if (accessRocket == null || accessRocket.MaxCount <= RocketsByType(rocketType).Length)
                return false;

            int id = Rockets.Max(d => d.Data.Id) + 1;
            var rocketData = new RocketData(rocketType, RocketDefinitions.Rocket[rocketType], id);
            var rocketModel = new RocketModel(rocketData);
            Rockets.Add(rocketModel);

            return true;
        }

        public (int, int) GetRocketOccupation(RocketType rocketType)
        {
            int count = 0;
            int max = 0;

            return (count, max);
        }

        private RocketModel[] RocketsByState(RocketState rocketState)
        {
            return Rockets.Where(d => d.Data.State == rocketState).ToArray();
        }

        private RocketModel[] RocketsByType(RocketType rocketType)
        {
            return Rockets.Where(d => d.Data.RocketType == rocketType).ToArray();
        }
    }
}
