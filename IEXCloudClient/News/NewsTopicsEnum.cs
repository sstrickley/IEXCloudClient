using System.ComponentModel;

namespace IEXCloudClient.News
{
    public enum NewsTopicsEnum
    {
        [Description("crypto")]
        Crypto,

        [Description("oil")]
        Oil,

        [Description("us-market")]
        USMarket,

        [Description("etfs")]
        ETFs,

        [Description("bonds")]
        Bonds,

        [Description("funding")]
        Funding,

        [Description("fx")]
        FX,

        [Description("capital-raise")]
        CapitalRaise
    }
}
