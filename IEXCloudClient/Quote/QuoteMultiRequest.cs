using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Quote
{
    internal class QuoteMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public QuoteMultiRequest(IEnumerable<string> symbols, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "quote");
        }
    }
}
