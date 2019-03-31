using Game.Articles;
using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System.Collections.Generic;
using System.Linq;

namespace Game.GameModel
{
    public class RocketsOrganizer
    {
        private IList<RocketModel> Rockets { get; }
        public PlayerData PlayerData { get; }
        public LaunchTowerData LaunchTowerData { get; }
        public RocketDefinitions RocketDefinitions { get; }

        public RocketsOrganizer(IList<RocketModel> rockets, PlayerData playerData, LaunchTowerData launchTowerData, RocketDefinitions rocketDefinitions)
        {
            Rockets = rockets;
            PlayerData = playerData;
            LaunchTowerData = launchTowerData;
            RocketDefinitions = rocketDefinitions;
        }

        public bool TryAddRocket(RocketType rocketType)
        {
            var accessRocket = RocketDefinitions.AccessRocketsDefinitions.FirstOrDefault(d => d.RocketType == rocketType.ToString());
            if (accessRocket == null || accessRocket.MaxCount <= RocketsByType(rocketType).Length)
                return false;

            int id = 1;
            if(Rockets.Count > 0)
                id = Rockets.Max(d => d.Data.Id) + 1;

            var rocketData = new RocketData(rocketType, RocketDefinitions.Rocket[rocketType], id);
            var rocketModel = new RocketModel(rocketData);
            Rockets.Add(rocketModel);

            return true;
        }

        public void ChangeState(RocketModel rocketModel, RocketState rocketState)
        {
            rocketModel.Data.State = rocketState;
        }

        public (int Count, int Max) GetRocketOccupation(RocketType rocketType)
        {
            int count = 0;
            int max = 0;

            return (count, max);
        }

        public RocketModel[] RocketsByState(RocketState rocketState)
        {
            return Rockets.Where(d => d.Data.State == rocketState).ToArray();
        }

        public RocketModel[] RocketsByType(RocketType rocketType)
        {
            return Rockets.Where(d => d.Data.RocketType == rocketType).ToArray();
        }
    }
}
