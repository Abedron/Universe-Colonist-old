using Xunit;
using Game.GameModel.Buildings;
using Game.DataModel.Runtime;

namespace UniverseColonistTests.GameModel
{
    public class BaseStationBuildingTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(7, 3)]
        [InlineData(8, 4)]
        [InlineData(9, 4)]
        [InlineData(99, 9)]
        public void TryRaiseLevel_SetLevelByDefinitions(int playerLevel, int expectedLevel)
        {
            // Arrange
            var data = new BaseStationData();
            var building = new BaseStationBuilding(data, TestEnvironment.BaseStationDefinitionsFake);

            // Act
            building.TryRaiseLevel(playerLevel);

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
            var data = new BaseStationData() { Level = dataLevel };
            var building = new BaseStationBuilding(data, TestEnvironment.BaseStationDefinitionsFake);

            // Act
            bool isRaisedLevel = building.TryRaiseLevel(playerLevel);

            // Assert
            Assert.Equal(expectedRaisedLevel, isRaisedLevel);
        }
    }
}
