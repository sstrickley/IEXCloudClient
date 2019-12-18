using IEXCloudClient.Common;
using IEXCloudClient.Quote;
using System.Collections.Generic;

namespace IEXCloudClient.Collections
{
    internal class CollectionRequest : BaseRequest<List<QuoteResponse>>
    {
        public CollectionRequest(CollectionTypeEnum type, string collectionName, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", "market", "collection", type.ToString());
            Parameters.Add("collectionName", collectionName);
        }
    }
}
