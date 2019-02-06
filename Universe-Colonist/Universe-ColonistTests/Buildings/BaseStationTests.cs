using Xunit;
using Game.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Configurations.Definitions;

namespace Game.Buildings
{
    public class BaseStationTests
    {
        [Fact]
        public void TryRaiseLevel()
        {
            // Arrange
            

            var baseStation = BaseStationTestEnvironment.SetupBaseStation();

            // Act
            //baseStation.TryRaiseLevel()

            // Assert
            Assert.True(false, "This test needs an implementation");
        }

        [Theory]
        [InlineData(1000, 0)]
        [InlineData(1110, 1)]
        [InlineData(1210, 2)]
        [InlineData(9999, 3)]
        public void Try(int xp, int expectedLevel)
        {
            var buildingDefinitions = new BuildingDefinition[]
            {
                new BuildingDefinition() {Level = 0, RewardXp = 0},
                new BuildingDefinition() {Level = 1, RewardXp = 1100},
                new BuildingDefinition() {Level = 2, RewardXp = 1200},
                new BuildingDefinition() {Level = 3, RewardXp = 1300}
            };

            BuildingDefinition definition = null;
            int length = buildingDefinitions.Length;
            for (int i = 0; i < length; i++)
            {
                if(buildingDefinitions[i].RewardXp > xp)
                {
                    definition = buildingDefinitions[Math.Max(0, i - 1)];
                    break;
                }

                if (i == length - 1)
                {
                    definition = buildingDefinitions[i];
                }
            }
            

            Assert.Equal(expectedLevel, definition?.Level);
        }
    }
}