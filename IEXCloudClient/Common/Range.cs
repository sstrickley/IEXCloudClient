using System.ComponentModel;

namespace IEXCloudClient.Common
{
    public enum Range
    {
        [Description("5y")]
        FiveYear,

        [Description("3y")]
        TwoYear,

        [Description("1y")]
        OneYear,

        [Description("ytd")]
        YearToDate,

        [Description("6m")]
        SixMonth,

        [Description("3m")]
        ThreeMonth,

        [Description("1m")]
        OneMonth,

        [Description("1d")]
        OneDay
    }
}
