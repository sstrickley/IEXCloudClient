using IEXCloudClient.Common;

namespace IEXCloudClient.Quote
{
    internal class QuoteRequest : BaseRequest<QuoteResponse>
    {
        public QuoteRequest(string symbol, string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("stock", symbol, "quote");
        }
    }
}
