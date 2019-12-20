using IEXCloudClient.Common;

namespace IEXCloudClient.Account
{
    internal class MetadataRequest : BaseRequest<MetadataResponse>
    {
        public MetadataRequest(string baseUrl, string token) : base(baseUrl, token)
        {
            SetEndpoint("account", "metadata");
        }
    }
}
