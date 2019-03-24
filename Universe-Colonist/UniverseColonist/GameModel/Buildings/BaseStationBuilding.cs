using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class BaseStationBuilding : BuildingBase
    {
        public BaseStationData Data { get; }
        private LevelUpModel LevelUp { get; }

        public BaseStationBuilding(BaseStationData data)
        {
            Data = data;
            LevelUp = new LevelUpModel(data);
        }

        public override bool TryLevelUp(int playerLevel)
        {

            bool isLevelUp = LevelUp.TryLevelUp(Data.Definitions, playerLevel);
            return isLevelUp;
        }
    }
}
