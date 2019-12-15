using IEXClient.Chart;
using IEXClient.Dividends;
using IEXClient.KeyStats;
using IEXClient.Quote;
using System.Collections.Generic;

namespace IEXCloudClient.Common
{
    public class RequestTypes
    {
        public List<ChartResponse> chart { get; set; }
        public KeyStatsResponse stats { get; set; }
        public List<DividendResponse> dividends { get; set; }
        public QuoteResponse quote { get; set; }
    }
}
