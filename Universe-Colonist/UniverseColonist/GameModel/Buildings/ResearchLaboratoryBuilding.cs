using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class ResearchLaboratoryBuilding : StandardBuildingBase
    {
        public ResearchLaboratoryData Data { get; }
        private LevelUpModel LevelUp { get; }

        public ResearchLaboratoryBuilding(ResearchLaboratoryData data)
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
