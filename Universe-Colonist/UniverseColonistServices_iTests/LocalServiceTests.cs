using System.Net.NetworkInformation;
using Xunit;

namespace Game.Services.Tests
{
    public class LocalServiceTests
    {
        [Fact]
        public void LoadTest()
        {
            // Arrange
            var localService = new LoaderService();

            // Act
            string json = localService.Load("_Data\\Config.json");

            // Assert
            Assert.NotNull(json);
        }

        [Fact]
        public void Check()
        {
            var connectionCheckup = new ConnectionCheckup();
            var ping = connectionCheckup.Check();

            Assert.True(ping.Result?.Status == IPStatus.Success);
        }
    }
}