using Xunit;
using Game.Services;
using Game.StockService;
using UniverseColonistTests;

namespace Game.Models.Tests
{
    public class GameModelTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(2000, 4)]
        [InlineData(1800000, 123)]
        public void LevelBuilding(int expectedXp, int expectedLevel)
        {
            // Arrange
            IConfigurationStock configurationStock = TestEnvironment.SetupConfigurationStock(expectedXp, expectedLevel);
            AllDefinitions allDefinitions = TestEnvironment.AllDefinitionsFake;

            // Act
            var gameModel = new GameModel(configurationStock, allDefinitions);

            // Assert
            Assert.Equal(expectedLevel, gameModel.GameGoods.Level);
        }
    }
}