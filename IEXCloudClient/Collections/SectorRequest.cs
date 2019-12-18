using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Collections
{
    internal class SectorRequest : BaseRequest<List<NamedItemResponse>>
    {
        public SectorRequest(string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("ref-data", "sectors");
        }
    }
}
