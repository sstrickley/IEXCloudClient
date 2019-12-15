using Common.Extensions;
using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Chart
{
    public class ChartRequest : BaseRequest<List<ChartResponse>>
    {
        public ChartRequest(string symbol, Range range, string token) : base()
        {
            SetEndpoint("stock", symbol, "chart", range.GetDescription());
            Parameters.Add("token", token);

        }
    }
}
