using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.News
{
    internal class NewsRequest : BaseRequest<List<NewsResponse>>
    {
        public NewsRequest(string baseUrl, string token, string symbolOrTopic, uint articles) : base(baseUrl, token)
        {
            SetEndpoint("stock", symbolOrTopic, "news", "last", articles.ToString());
        }
    }
}
