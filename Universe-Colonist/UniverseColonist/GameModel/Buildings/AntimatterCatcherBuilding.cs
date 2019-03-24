using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class AntimatterCatcherBuilding : StandardBuildingBase
    {
        public AntimatterCatcherData Data { get; }
        private LevelUpModel LevelUp { get; }

        public AntimatterCatcherBuilding(AntimatterCatcherData data)
        {
            Data = data;
            LevelUp = new LevelUpModel(data);
        }

        public override bool TryLevelUp(int baseStationLevel)
        {
            bool isLevelUp = LevelUp.TryLevelUp(Data.Definitions, baseStationLevel);
            return isLevelUp;
        }

        public bool TryAddHarvester()
        {


            return false;
        }
    }
}
