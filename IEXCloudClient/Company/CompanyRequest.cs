using IEXCloudClient.Common;

namespace IEXCloudClient.Company
{
    internal class CompanyRequest : BaseRequest<CompanyResponse>
    {
        public CompanyRequest(string baseUrl, string token, string symbol) : base(baseUrl, token)
        {
            SetEndpoint("stock", symbol, "company");
        }
    }
}
