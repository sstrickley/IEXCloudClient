using IEXCloudClient.Chart;
using System.Collections.Generic;

namespace IEXCloudClient.Indicator
{
    public class IndicatorResponse
    {
        public List<List<double?>> indicator { get; set; }
        public List<ChartResponse> chart { get; set; }
    }
}
