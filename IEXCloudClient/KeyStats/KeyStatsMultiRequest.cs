using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.KeyStats
{
    internal class KeyStatsMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public KeyStatsMultiRequest(IEnumerable<string> symbols, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "stats");
        }
    }
}
