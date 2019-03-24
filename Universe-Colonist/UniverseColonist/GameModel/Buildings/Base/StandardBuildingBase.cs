using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class StandardBuildingBase : BuildingBase
    {
        public BuildingDataBase<ILevelUpByBaseStationDefinition> Data { get; }

        private LevelUpModel LevelUp { get; }

        public StandardBuildingBase(BuildingDataBase<ILevelUpByBaseStationDefinition> data)
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
