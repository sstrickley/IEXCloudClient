using IEXCloudClient.Common;
using System.Collections.Generic;

namespace IEXCloudClient.Collections
{
    internal class TagRequest : BaseRequest<List<NamedItemResponse>>
    {
        public TagRequest(string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("ref-data", "tags");
        }
    }
}
