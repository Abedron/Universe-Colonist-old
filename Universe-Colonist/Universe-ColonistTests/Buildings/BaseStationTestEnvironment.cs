using Game.Configurations.Definitions;

namespace Game.Buildings
{
    public class BaseStationTestEnvironment
    {
        public static BaseStation SetupBaseStation()
        {
            var baseStation = new BaseStation(GetBuildingDefinition());

            return baseStation;
        }

        private static BuildingDefinition[] GetBuildingDefinition()
        {
            var buildingDefinitions = new BuildingDefinition[]
            {
                new BuildingDefinition() {Level = 0, RewardXp = 0},
                new BuildingDefinition() {Level = 1, RewardXp = 1100},
                new BuildingDefinition() {Level = 2, RewardXp = 1200},
                new BuildingDefinition() {Level = 3, RewardXp = 1300},
                new BuildingDefinition() {Level = 4, RewardXp = 1400},
                new BuildingDefinition() {Level = 5, RewardXp = 1600},
                new BuildingDefinition() {Level = 6, RewardXp = 1700}
            };

            return buildingDefinitions;
        }
    }
}