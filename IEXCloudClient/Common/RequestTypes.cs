using IEXCloudClient.Chart;
using IEXCloudClient.Company;
using IEXCloudClient.Dividends;
using IEXCloudClient.KeyStats;
using IEXCloudClient.News;
using IEXCloudClient.Quote;
using System.Collections.Generic;

namespace IEXCloudClient.Common
{
    public class RequestTypes
    {
        public List<ChartResponse> chart { get; set; }
        public KeyStatsResponse stats { get; set; }
        public List<DividendResponse> dividends { get; set; }
        public QuoteResponse quote { get; set; }
        public CompanyResponse company { get; set; }
        public List<NewsResponse> news { get; set; }
    }
}
