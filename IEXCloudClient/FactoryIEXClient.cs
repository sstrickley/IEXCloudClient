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
    public class FactoryIEXClient : IFactoryIEXClient
    {
        private readonly string _baseUrl;
        private readonly string _token;

        public FactoryIEXClient(string baseUrl, string token)
        {
            _baseUrl = baseUrl;
            _token = token;
        }

        public IRequest<QuoteResponse> GetQuoteRequest(string symbol)
        {
            return new QuoteRequest(symbol, _baseUrl, _token);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetQuoteMultiRequest(IEnumerable<string> symbol)
        {
            return new QuoteMultiRequest(symbol, _baseUrl, _token);
        }

        public IRequest<List<ChartResponse>> GetChartRequest(string symbol, DateRangeEnum range)
        {
            return new ChartRequest(symbol, range, _baseUrl, _token);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetChartMultiRequest(IEnumerable<string> symbols, DateRangeEnum range)
        {
            return new ChartMultiRequest(symbols, range, _baseUrl, _token);
        }

        public IRequest<List<ChartResponse>> GetCloseOnlyChartRequest(string symbol, DateRangeEnum range)
        {
            var req = new ChartRequest(symbol, range, _baseUrl, _token);
            req.GetCloseOnly();

            return req;
        }

        public IRequest<Dictionary<string, RequestTypes>> GetCloseOnlyChartMultiRequest(IEnumerable<string> symbols, DateRangeEnum range)
        {
            var req = new ChartMultiRequest(symbols, range, _baseUrl, _token);
            req.GetCloseOnly();

            return req;
        }

        public IRequest<KeyStatsResponse> GetKeyStatsRequest(string symbol)
        {
            return new KeyStatsRequest(symbol, _baseUrl, _token);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetKeyStatsMultiRequest(IEnumerable<string> symbols)
        {
            return new KeyStatsMultiRequest(symbols, _baseUrl, _token);
        }

        public IRequest<List<DividendResponse>> GetDividendRequest(string symbol, DateRangeEnum range)
        {
            return new DividendRequest(symbol, range, _baseUrl, _token);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetDividendMultiRequest(IEnumerable<string> symbols, DateRangeEnum range)
        {
            return new DividendMultiRequest(symbols, range, _baseUrl, _token);
        }

        public IRequest<IndicatorResponse> GetIndicatorRequest(string symbol, IndicatorEnum indicator, DateRangeEnum range)
        {
            return new IndicatorRequest(symbol, indicator, range, _baseUrl, _token);
        }

        public IRequest<List<QuoteResponse>> GetCollectionRequest(CollectionTypeEnum type, string collectionName)
        {
            return new CollectionRequest(type, collectionName, _baseUrl, _token);
        }

        public IRequest<List<NamedItemResponse>> GetSectorsRequest()
        {
            return new SectorRequest(_baseUrl, _token);
        }

        public IRequest<List<NamedItemResponse>> GetTagsRequest()
        {
            return new TagRequest(_baseUrl, _token);
        }

        public IRequest<MetadataResponse> GetMetadataRequest()
        {
            return new MetadataRequest(_baseUrl, _token);
        }

        public IRequest<CompanyResponse> GetCompanyRequest(string symbol)
        {
            return new CompanyRequest(_baseUrl, _token, symbol);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetCompanyMultiRequest(IEnumerable<string> symbols)
        {
            return new CompanyMultiRequest(_baseUrl, _token, symbols);
        }

        public IRequest<List<NewsResponse>> GetNewsRequest(string symbol, uint articles = 10)
        {
            return new NewsRequest(_baseUrl, _token, symbol, articles);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetNewsMultiRequest(IEnumerable<string> symbols, uint articles = 10)
        {
            return new NewsMultiRequest(_baseUrl, _token, symbols, articles);
        }
    }
}
