using IEXCloudClient.Common;

namespace IEXCloudClient.KeyStats
{
    internal class KeyStatsRequest : BaseRequest<KeyStatsResponse>
    {
        public KeyStatsRequest(string symbol, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", symbol, "stats");
        }
    }
}
