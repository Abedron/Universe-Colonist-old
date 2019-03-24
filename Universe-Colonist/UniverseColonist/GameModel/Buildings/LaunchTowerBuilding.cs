using Game.DataModel.Runtime;

namespace Game.GameModel.Buildings
{
    public class LaunchTowerBuilding : StandardBuildingBase
    {
        public LaunchTowerData Data { get; }
        private LevelUpModel LevelUp { get; }

        public LaunchTowerBuilding(LaunchTowerData data)
        {
            Data = data;
            LevelUp = new LevelUpModel(data);
        }

        public override bool TryLevelUp(int baseStationLevel)
        {
            bool isLevelUp = LevelUp.TryLevelUp(Data.Definitions, baseStationLevel);
            return isLevelUp;
        }

    }
}
