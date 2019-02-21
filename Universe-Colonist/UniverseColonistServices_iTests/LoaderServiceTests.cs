using Game.Services;
using Xunit;

namespace UniverseColonistServicesTests
{
    public class LocalServiceTests
    {

        [Fact]
        public void LoadAllDefinitions()
        {
            // Arrange
            var localService = new LocalDefinitionsService();

            // Act
            localService.LoadAllDefinitions();

            // Assert
            Assert.NotNull(localService.ConfigDefinitions.Version);
            Assert.NotEmpty(localService.AllDefinitions.Player);
            Assert.NotEmpty(localService.AllDefinitions.Buildings.AntimatterCatcher);
            Assert.NotEmpty(localService.AllDefinitions.Buildings.BaseStation);
            Assert.NotEmpty(localService.AllDefinitions.Buildings.FuelRefinery);
            Assert.NotEmpty(localService.AllDefinitions.Buildings.LaunchTower);
            Assert.NotEmpty(localService.AllDefinitions.Buildings.RecruitmentOfColonist);
            Assert.NotEmpty(localService.AllDefinitions.Buildings.ResearchLaboratory);
            Assert.NotEmpty(localService.AllDefinitions.Buildings.ResourceObservatory);
        }
    }
}