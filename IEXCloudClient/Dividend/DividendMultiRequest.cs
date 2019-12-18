using IEXCloudClient.Utility;
using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Dividends
{
    internal class DividendMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public DividendMultiRequest(IEnumerable<string> symbols, Range range, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "dividends");
            Parameters.Add("range", range.GetDescription());
        }
    }
}
