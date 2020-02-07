using IEXCloudClient.Utility;
using System;

namespace IEXCloudClient.News
{
    public class NewsResponse
    {
        public string datetime { get; set; }
        public DateTime? DateTime { get => PropertyConverters.ParseUnixTimeMS(datetime); }
        public string headline { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public string summary { get; set; }
        public string related { get; set; }
        public string image { get; set; }
        public string lang { get; set; }
        public bool hasPaywall { get; set; }
    }
}
