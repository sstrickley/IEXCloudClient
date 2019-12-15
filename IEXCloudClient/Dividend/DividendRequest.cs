using Common.Extensions;
using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Dividends
{
    public class DividendRequest : BaseRequest<List<DividendResponse>>
    {
        public DividendRequest(string symbol, Range range, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", symbol, "dividends", range.GetDescription());
        }
    }
}
