using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.News
{
    internal class NewsMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public NewsMultiRequest(string baseUrl, string token, IEnumerable<string> symbolsOrTopics, uint articles) : base(baseUrl, token)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbolsOrTopics));
            Parameters.Add("types", "news");
            Parameters.Add("last", articles.ToString());
        }
    }
}
