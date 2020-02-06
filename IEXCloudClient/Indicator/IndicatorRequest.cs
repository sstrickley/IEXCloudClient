using IEXCloudClient.Common;
using IEXCloudClient.Utility;

namespace IEXCloudClient.Indicator
{
    internal class IndicatorRequest : BaseRequest<IndicatorResponse>
    {
        public IndicatorRequest(string stock, IndicatorEnum indicator, DateRangeEnum range, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", stock, "indicator", indicator.ToString());
            Parameters.Add("range", range.GetDescription());
        }
    }
}
