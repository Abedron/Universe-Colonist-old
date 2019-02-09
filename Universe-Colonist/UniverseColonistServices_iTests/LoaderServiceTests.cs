using Game.Services;
using Xunit;

namespace UniverseColonistServicesTests
{
    public class LocalServiceTests
    {
        [Fact]
        public void CtorLoaderService_ConstructorLoadedConfig_VersionIsNotNullInConfigI()
        {
            // Act
            var localService = new DefinitionsService();

            // Assert
            Assert.NotNull(localService.Config.Version);
        }

        [Fact]
        public void LoadAllDefinitions()
        {
            // Arrange
            var localService = new DefinitionsService();

            // Act
            localService.LoadAllDefinitions();

            // Assert
            Assert.NotEmpty(localService.GameDefinitions.Game);
            Assert.NotEmpty(localService.GameDefinitions.Buildings.AntimatterCatcher);
            Assert.NotEmpty(localService.GameDefinitions.Buildings.BaseStation);
            Assert.NotEmpty(localService.GameDefinitions.Buildings.FuelRefinery);
            Assert.NotEmpty(localService.GameDefinitions.Buildings.LaunchTowerRockets);
            Assert.NotEmpty(localService.GameDefinitions.Buildings.RecruitmentOfColonist);
            Assert.NotEmpty(localService.GameDefinitions.Buildings.ResearchLaboratory);
            Assert.NotEmpty(localService.GameDefinitions.Buildings.ResourceObservatory);
        }
    }
}