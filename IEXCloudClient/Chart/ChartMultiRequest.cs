using IEXCloudClient.Utility;
using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Chart
{
    internal class ChartMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public ChartMultiRequest(IEnumerable<string> symbols, Range range, string endpoint, string token) : base(endpoint, token)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "chart");
            Parameters.Add("range", range.GetDescription());
        }
    }
}
