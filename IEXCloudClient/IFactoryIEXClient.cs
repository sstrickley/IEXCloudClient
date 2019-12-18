﻿using IEXCloudClient.Chart;
using IEXCloudClient.Collections;
using IEXCloudClient.Common;
using IEXCloudClient.Dividends;
using IEXCloudClient.Indicator;
using IEXCloudClient.KeyStats;
using IEXCloudClient.Quote;
using System.Collections.Generic;

namespace IEXCloudClient
{
    public interface IFactoryIEXClient
    {
        IRequest<QuoteResponse> GetQuoteRequest(string symbol);
        IRequest<Dictionary<string, RequestTypes>> GetQuoteMultiRequest(IEnumerable<string> symbols);
        IRequest<List<ChartResponse>> GetChartRequest(string symbol, Range range);
        IRequest<Dictionary<string, RequestTypes>> GetChartMultiRequest(IEnumerable<string> symbols, Range range);
        IRequest<KeyStatsResponse> GetKeyStatsRequest(string symbol);
        IRequest<Dictionary<string, RequestTypes>> GetKeyStatsMultiRequest(IEnumerable<string> symbols);
        IRequest<List<DividendResponse>> GetDividendRequest(string symbol, Range range);
        IRequest<Dictionary<string, RequestTypes>> GetDividendMultiRequest(IEnumerable<string> symbols, Range range);
        IRequest<IndicatorResponse> GetIndicatorRequest(string symbol, IndicatorEnum indicator, Range range);
        IRequest<List<QuoteResponse>> GetCollectionRequest(CollectionTypeEnum type, string collectionName);
        IRequest<List<NamedItemResponse>> GetSectorsRequest();
        IRequest<List<NamedItemResponse>> GetTagsRequest();
    }
}