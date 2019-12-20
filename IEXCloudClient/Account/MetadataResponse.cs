namespace IEXCloudClient.Account
{
    public class MetadataResponse
    {
        public bool payAsYouGoEnabled { get; set; }

        public long effectiveDate { get; set; }

        public long endDateEffective { get; set; }

        public string subscriptionTermType { get; set; }

        public string tierName { get; set; }

        public long messageLimit { get; set; }

        public long messagesUsed { get; set; }

        public long circuitBreaker { get; set; }

    }
}
