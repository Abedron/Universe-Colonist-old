using Xunit;
using Game.GameModel.Buildings;
using System;

namespace UniverseColonistTests.GameModel
{
    public class HarvesterTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 10)]
        [InlineData(5, 50)]
        [InlineData(10, 100)]
        [InlineData(2000, 100)]
        public void GetHarvestResources_CustomTime_ResourcesByElapsedTime(int harvestingTime, int expectedResource)
        {
            // Arrange
            var definition = TestEnvironment.AllDefinitionsFake.Buildings.AntimatterCatcher[0];
            var harvester = new Harvester(definition, new DateTime());
            var currentTime = new DateTime().AddSeconds(harvestingTime);

            // Act
            int resource = harvester.GetHarvestResources(currentTime);

            // Assert
            Assert.Equal(resource, expectedResource);
        }
    }
}
