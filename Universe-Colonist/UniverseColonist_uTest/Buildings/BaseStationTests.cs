using Game.Buildings;
using Xunit;

namespace UniverseColonistTests.Buildings
{
    public class BaseStationTests
    {
        [Theory]
        [InlineData(1000,  0, false)]
        [InlineData(1110,  0,  true)]
        [InlineData(1190,  1, false)]
        [InlineData(9999,  1,  true)]
        [InlineData(99999, 6, false)]
        public void TryRaiseLevel_WithRelevantDefinitions_IsLevelUpByXp(int xp, int currentLevel, bool isLevelUpExpected)
        {
            // Arrange
            var baseStation = new BaseStation(TestEnvironment.BuildingDefinitions)
            {
                Level = currentLevel
            };

            // Act
            bool isLevelUp = baseStation.TryRaiseLevel(xp);

            // Assert
            Assert.Equal(isLevelUpExpected, isLevelUp);
        }

        [Theory]
        [InlineData(1000,  0,  0)]
        [InlineData(1110,  0,  1)]
        [InlineData(1190,  1,  1)]
        [InlineData(9999,  1,  6)]
        [InlineData(99999, 6,  6)]
        public void TryRaiseLevel_WithRelevantDefinitions_RaiseLevelUpByXp(int xp, int currentLevel, int expectedLevel)
        {
            // Arrange
            var baseStation = new BaseStation(TestEnvironment.BuildingDefinitions)
            {
                Level = currentLevel
            };

            // Act
            baseStation.TryRaiseLevel(xp);

            // Assert
            Assert.Equal(expectedLevel, baseStation.Level);
        }
    }
}