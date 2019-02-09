using System.Net.NetworkInformation;
using Game.Services;
using Xunit;

namespace UniverseColonistServicesTests
{
    public class ConnectionCheckupTests
    {
        [Fact]
        public void Check_PcIsConnectToInternet_IpStatusIsSuccess()
        {
            var connectionCheckup = new ConnectionCheckup();
            var ping = connectionCheckup.Check();

            Assert.True(ping.Result?.Status == IPStatus.Success);
        }
    }
}