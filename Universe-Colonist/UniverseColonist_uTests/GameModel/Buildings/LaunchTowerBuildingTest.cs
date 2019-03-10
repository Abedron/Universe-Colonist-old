using Xunit;
using Game.GameModel.Buildings;
using Game.DataModel.Runtime;

namespace UniverseColonistTests.GameModel
{
    public class LaunchTowerBuildingTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]
        public void TryRaiseLevel_SetLevelByDefinitions(int baseStationLevel, int expectedLevel)
        {
            // Arrange
            var data = new LaunchTowerData();
            var building = new LaunchTowerBuilding(data, TestEnvironment.LaunchTowerDefinitionsFake);

            // Act
            building.TryRaiseLevel(baseStationLevel);

            // Assert
            Assert.Equal(expectedLevel, data.Level);
        }

        [Theory]
        [InlineData(0, 1, false)]
        [InlineData(1, 1, false)]
        [InlineData(7, 3, true)]
        [InlineData(8, 3, true)]
        [InlineData(9, 3, true)]
        [InlineData(99, 9, false)]
        public void TryRaiseLevel_IsRaisedLevelByDefinitions(int baseStationLevel, int dataLevel, bool expectedRaisedLevel)
        {
            // Arrange
            var data = new LaunchTowerData() { Level = dataLevel };
            var building = new LaunchTowerBuilding(data, TestEnvironment.LaunchTowerDefinitionsFake);

            // Act
            bool isRaisedLevel = building.TryRaiseLevel(baseStationLevel);

            // Assert
            Assert.Equal(expectedRaisedLevel, isRaisedLevel);
        }
    }
}
