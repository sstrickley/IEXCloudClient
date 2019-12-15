using Common.Converters;
using System;

namespace IEXCloudClient.Dividends
{
    public class DividendResponse
    {
        public string exDate { get; set; }
        public string paymentDate { get; set; }
        public string recordDate { get; set; }
        public string declaredDate { get; set; }
        public double? amount { get; set; }
        public string type { get; set; }
        public string qualified { get; set; }

        public DateTime? ExDate
        {
            get { return ParseDateTime(exDate); }
        }

        public DateTime? PaymentDate
        {
            get { return ParseDateTime(paymentDate); }
        }

        public DateTime? RecordDate
        {
            get { return ParseDateTime(recordDate); }
        }

        public DateTime? DeclaredDate
        {
            get { return ParseDateTime(declaredDate); }
        }

        private DateTime? ParseDateTime(string date)
        {
            try
            {
                return PropertyConverters.ParseDateTime(date, DateTimeFormats.DateYmd);
            }
            catch (FormatException)
            {
                return null;
            }
        }
        
        
    }
}
