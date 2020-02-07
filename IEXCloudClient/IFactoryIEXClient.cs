using IEXCloudClient.Account;
using IEXCloudClient.Chart;
using IEXCloudClient.Collections;
using IEXCloudClient.Common;
using IEXCloudClient.Company;
using IEXCloudClient.Dividends;
using IEXCloudClient.Indicator;
using IEXCloudClient.KeyStats;
using IEXCloudClient.News;
using IEXCloudClient.Quote;
using System.Collections.Generic;

namespace IEXCloudClient
{
    public interface IFactoryIEXClient
    {
        IRequest<QuoteResponse> GetQuoteRequest(string symbol);
        IRequest<Dictionary<string, RequestTypes>> GetQuoteMultiRequest(IEnumerable<string> symbols);
        IRequest<List<ChartResponse>> GetChartRequest(string symbol, DateRangeEnum range);
        IRequest<Dictionary<string, RequestTypes>> GetChartMultiRequest(IEnumerable<string> symbols, DateRangeEnum range);
        IRequest<List<ChartResponse>> GetCloseOnlyChartRequest(string symbol, DateRangeEnum range);
        IRequest<Dictionary<string, RequestTypes>> GetCloseOnlyChartMultiRequest(IEnumerable<string> symbols, DateRangeEnum range);
        IRequest<KeyStatsResponse> GetKeyStatsRequest(string symbol);
        IRequest<Dictionary<string, RequestTypes>> GetKeyStatsMultiRequest(IEnumerable<string> symbols);
        IRequest<List<DividendResponse>> GetDividendRequest(string symbol, DateRangeEnum range);
        IRequest<Dictionary<string, RequestTypes>> GetDividendMultiRequest(IEnumerable<string> symbols, DateRangeEnum range);
        IRequest<IndicatorResponse> GetIndicatorRequest(string symbol, IndicatorEnum indicator, DateRangeEnum range);
        IRequest<List<QuoteResponse>> GetCollectionRequest(CollectionTypeEnum type, string collectionName);
        IRequest<List<NamedItemResponse>> GetSectorsRequest();
        IRequest<List<NamedItemResponse>> GetTagsRequest();
        IRequest<MetadataResponse> GetMetadataRequest();
        IRequest<CompanyResponse> GetCompanyRequest(string symbol);
        IRequest<Dictionary<string, RequestTypes>> GetCompanyMultiRequest(IEnumerable<string> symbols);
        IRequest<List<NewsResponse>> GetNewsRequest(string symbol, uint articles = 10);
        IRequest<Dictionary<string, RequestTypes>> GetNewsMultiRequest(IEnumerable<string> symbols, uint articles = 10);
    }
}
