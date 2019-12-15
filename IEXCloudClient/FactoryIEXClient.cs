using IEXCloudClient.Chart;
using IEXCloudClient.Common;
using IEXCloudClient.Dividends;
using IEXCloudClient.KeyStats;
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

        public IRequest<List<ChartResponse>> GetChartRequest(string symbol, Range range)
        {
            return new ChartRequest(symbol, range, _baseUrl, _token);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetChartMultiRequest(IEnumerable<string> symbols, Range range)
        {
            return new ChartMultiRequest(symbols, range, _baseUrl, _token);
        }

        public IRequest<KeyStatsResponse> GetKeyStatsRequest(string symbol)
        {
            return new KeyStatsRequest(symbol, _baseUrl, _token);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetKeyStatsMultiRequest(IEnumerable<string> symbols)
        {
            return new KeyStatsMultiRequest(symbols, _baseUrl, _token);
        }

        public IRequest<List<DividendResponse>> GetDividendRequest(string symbol, Range range)
        {
            return new DividendRequest(symbol, range, _baseUrl, _token);
        }

        public IRequest<Dictionary<string, RequestTypes>> GetDividendMultiRequest(IEnumerable<string> symbols, Range range)
        {
            return new DividendMultiRequest(symbols, range, _baseUrl, _token);
        }
    }
}
