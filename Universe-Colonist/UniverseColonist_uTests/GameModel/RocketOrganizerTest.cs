using Xunit;
using Game.Articles;
using UniverseColonistTests;
using System.Collections.Generic;

namespace Game.GameModel.Tests
{
    public class RocketOrganizerTest
    {
        [Fact]
        public void TryAddRocket_AddOneRocket_OneBlueLightRocketAdded()
        {
            // Arrange
            var rocketOrganizer = new RocketsOrganizer(new List<RocketModel>(), TestEnvironment.PlayerData, TestEnvironment.LaunchTowerData, TestEnvironment.AllDefinitionsFake.Rockets);

            // Act
            bool result = rocketOrganizer.TryAddRocket(RocketType.BlueLight);

            // Assert
            Assert.Single(rocketOrganizer.RocketsByType(RocketType.BlueLight));
            Assert.True(result);
        }

        [Fact]
        public void TryAddRocket_AddThreeRockets_TwoBlueLightRocketAdded()
        {
            // Arrange
            var rocketOrganizer = new RocketsOrganizer(new List<RocketModel>(), TestEnvironment.PlayerData, TestEnvironment.LaunchTowerData, TestEnvironment.AllDefinitionsFake.Rockets);

            // Act
            rocketOrganizer.TryAddRocket(RocketType.BlueLight);
            rocketOrganizer.TryAddRocket(RocketType.BlueLight);
            bool result = rocketOrganizer.TryAddRocket(RocketType.BlueLight);

            // Assert
            Assert.Equal(2, rocketOrganizer.RocketsByType(RocketType.BlueLight).Length);
            Assert.False(result);
        }
    }
}