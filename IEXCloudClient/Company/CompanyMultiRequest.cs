using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Company
{
    internal class CompanyMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public CompanyMultiRequest(string baseUrl, string token, IEnumerable<string> symbols) : base(baseUrl, token)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "company");
        }
    }
}
