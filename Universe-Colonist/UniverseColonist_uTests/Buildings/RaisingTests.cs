using Xunit;
using Game.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Goods;
using Game.Services.Definitions;
using UniverseColonistTests;

namespace Game.Buildings.Tests
{
    public class RaisingTests
    {
        [Theory]
        [InlineData(1000, 0, false)]
        [InlineData(1110, 0, true)]
        [InlineData(1190, 1, false)]
        [InlineData(9999, 1, true)]
        [InlineData(99999, 6, false)]
        public void TryRaiseLevel_WithRelevantDefinitions_IsLevelUpByXp(int xp, int currentLevel, bool isLevelUpExpected)
        {
            // Arrange
            var baseStation = new Raising(currentLevel, TestEnvironment.BaseStationDefinitionsFake);

            // Act
            bool isLevelUp = baseStation.TryRaiseLevel(xp);

            // Assert
            Assert.Equal(isLevelUpExpected, isLevelUp);
        }

        [Theory]
        [InlineData(1000, 0, 0)]
        [InlineData(1110, 0, 1)]
        [InlineData(1190, 1, 1)]
        [InlineData(9999, 1, 6)]
        [InlineData(99999, 6, 6)]
        public void TryRaiseLevel_WithRelevantDefinitions_RaiseLevelUpByXp(int xp, int currentLevel, int expectedLevel)
        {
            // Arrange
            var baseStation = new Raising(currentLevel, TestEnvironment.BaseStationDefinitionsFake);

            // Act
            baseStation.TryRaiseLevel(xp);

            // Assert
            Assert.Equal(expectedLevel, baseStation.Level);
        }

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
            IRaiseDefinition[] buildingDefinitions = TestEnvironment.BaseStationDefinitionsFake;

            // Act
            int level = Raising.GetCalculateLevel(buildingDefinitions, xp);

            // Assert
            Assert.Equal(expectedLevel, level);
        }
    }
}