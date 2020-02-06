using System.ComponentModel;

namespace IEXCloudClient.Common
{
    public enum DateRangeEnum
    {
        [Description("5y")]
        FiveYear = 1825,

        [Description("3y")]
        TwoYear = 730,

        [Description("1y")]
        OneYear = 365,

        [Description("ytd")]
        YearToDate = 0,

        [Description("6m")]
        SixMonth = 180,

        [Description("3m")]
        ThreeMonth = 90,

        [Description("1m")]
        OneMonth = 30,

        [Description("1d")]
        OneDay = 1
    }
}
