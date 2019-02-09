using Game.Buildings;
using Xunit;

namespace UniverseColonistTests
{
    public class GameExtensionsTests
    {
        [Theory]
        [InlineData(1000, 0)]
        [InlineData(1099, 0)]
        [InlineData(1100, 1)]
        [InlineData(1199, 1)]
        [InlineData(1999, 6)]
        [InlineData(9999, 6)]
        public void TryRaiseLevel_WithRelevantDefinitions_LevelsCorrespondOfXp(int xp, int expectedLevel)
        {
            // Arrange
            ILeveling[] buildingDefinitions = TestEnvironment.BuildingDefinitions;

            // Act
            int level = buildingDefinitions.GetRaiseLevel(xp);

            // Assert
            Assert.Equal(expectedLevel, level);
        }
    }
}