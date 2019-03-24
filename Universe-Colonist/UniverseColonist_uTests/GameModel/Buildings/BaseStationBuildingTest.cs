using Xunit;
using Game.GameModel.Buildings;
using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace UniverseColonistTests.GameModel
{
    public class BaseStationBuildingTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(7, 2)]
        [InlineData(8, 2)]
        [InlineData(9, 2)]
        [InlineData(99, 2)]
        public void TryRaiseLevel_SetLevelByDefinitions(int playerLevel, int expectedLevel)
        {
            // Arrange
            var data = new BaseStationData<ILevelUpByPlayerDefinition>(TestEnvironment.BaseStationDefinitionsFake) { Level = 1};
            var building = new BaseStationBuilding(data);

            // Act
            building.TryLevelUp(playerLevel);

            // Assert
            Assert.Equal(expectedLevel, data.Level);
        }

        [Theory]
        [InlineData(0, 1, false)]
        [InlineData(1, 1, false)]
        [InlineData(7, 3, false)]
        [InlineData(8, 3, true)]
        [InlineData(9, 3, true)]
        [InlineData(99, 9, false)]
        public void TryRaiseLevel_IsRaisedLevelByDefinitions(int playerLevel, int dataLevel, bool expectedRaisedLevel)
        {
            // Arrange
            var data = new BaseStationData<ILevelUpByPlayerDefinition>(TestEnvironment.BaseStationDefinitionsFake) { Level = dataLevel };
            var building = new BaseStationBuilding(data);

            // Act
            bool isRaisedLevel = building.TryLevelUp(playerLevel);

            // Assert
            Assert.Equal(expectedRaisedLevel, isRaisedLevel);
        }
    }
}
