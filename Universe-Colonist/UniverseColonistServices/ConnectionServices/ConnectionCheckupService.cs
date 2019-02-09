using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Game.Services
{
    public class ConnectionCheckupService
    {
        public delegate void PingCompleteDelegate(bool success);

        public event PingCompleteDelegate OnCheckComplete;

        private readonly string url;

        public ConnectionCheckupService(string url = "google.com")
        {
            this.url = url;
        }

        public async Task<PingReply> Check()
        {
            try
            {
                using (Ping myPing = new Ping())
                {
                    String host = url;
                    byte[] buffer = new byte[32];
                    int timeout = 1000;
                    myPing.PingCompleted += PingCompleteHandler;
                    PingOptions pingOptions = new PingOptions();
                    return await myPing.SendPingAsync(host, timeout, buffer, pingOptions);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void PingCompleteHandler(object sender, PingCompletedEventArgs e)
        {
            bool status = e.Reply?.Status == IPStatus.Success;
            OnCheckComplete?.Invoke(status);
        }
    }
}