using IEXCloudClient.Utility;
using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Chart
{
    internal class ChartRequest : BaseRequest<List<ChartResponse>>
    {
        public ChartRequest(string symbol, DateRangeEnum range, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", symbol, "chart", range.GetDescription());
        }

        public void GetCloseOnly()
        {
            Parameters.Add("chartCloseOnly", "true");
        }
    }
}
