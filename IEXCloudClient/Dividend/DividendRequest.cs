using IEXCloudClient.Utility;
using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Dividends
{
    internal class DividendRequest : BaseRequest<List<DividendResponse>>
    {
        public DividendRequest(string symbol, Range range, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", symbol, "dividends", range.GetDescription());
        }
    }
}
