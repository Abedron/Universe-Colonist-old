using Game.DataModel.Runtime;
using System.Collections.Generic;
using System.Linq;

namespace Game.GameModel.Buildings
{
    public class LaunchTowerBuilding : StandardBuildingBase
    {
        private const int MAX_ROCKETS_OUTSIDE = 3;

        public List<RocketModel> Rockets { get; }
        public LaunchTowerData Data { get; }
        private LevelUpModel LevelUp { get; }

        public LaunchTowerBuilding(LaunchTowerData data, List<RocketModel> rockets)
        {
            Data = data;
            Rockets = rockets;

            LevelUp = new LevelUpModel(data);
        }

        public override bool TryLevelUp(int baseStationLevel)
        {
            bool isLevelUp = LevelUp.TryLevelUp(Data.Definitions, baseStationLevel);
            return isLevelUp;
        }

        private RocketModel[] GetRocketsInTower()
        {
            return Rockets.Where(d => d.Data.State == RocketState.LaunchTowerIn).ToArray();
        }

        private RocketModel[] GetRocketsOutTower()
        {
            return Rockets.Where(d => d.Data.State == RocketState.LaunchTowerOut).ToArray();
        }
    }
}
