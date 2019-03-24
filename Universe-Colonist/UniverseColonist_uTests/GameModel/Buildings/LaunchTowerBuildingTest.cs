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
            var building = new LaunchTowerBuilding(TestEnvironment.LaunchTowerData);

            // Act
            building.TryLevelUp(baseStationLevel);

            // Assert
            Assert.Equal(expectedLevel, building.Data.Level);
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
            var building = new LaunchTowerBuilding(TestEnvironment.LaunchTowerData);
            building.Data.Level = dataLevel;

            // Act
            bool isRaisedLevel = building.TryLevelUp(baseStationLevel);

            // Assert
            Assert.Equal(expectedRaisedLevel, isRaisedLevel);
        }
    }
}
