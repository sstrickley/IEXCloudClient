# IEXCloudClient
.NET Standard Client Library for the IEX Cloud API

All requests can be made through the FactoryIEXClient class.  This class requires the Base URL and your access token as parameters.   This allows you to inject the sandbox URL and test token during testing.  The FactoryIEXClient class implements the IFactoryIEXClient interface which can be mocked for testing.

Requests that end with "MultiRequest" support requests for multiple symbols.   These requests return a dictionary containing the symbol as the key and a "RequestType" object as the value.  

Example
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXCloudClient.ConsoleTester
{
    public class QuoteRequestTester
    {
        private readonly IFactoryIEXClient factory;

        public QuoteRequestTester(IFactoryIEXClient factory)
        {
            this.factory = factory;
        }

        public async Task TestQuoteRequest()
        {
            var request = factory.GetQuoteRequest("AAPL");
            var response = await request.SendRequestAsync();

            Console.WriteLine($"{response.symbol}: Bid {response.iexBidPrice} Ask {response.iexAskPrice} Vol {response.avgTotalVolume}");
        }

        public async Task TestQuoteMultiRequestAsync()
        {
            var request = factory.GetQuoteMultiRequest(new List<string> { "AAPL", "ON" });
            var response = await request.SendRequestAsync();

            foreach(var quote in response.Select(a => a.Value.quote))
                Console.WriteLine($"{quote.symbol}: Bid {quote.iexBidPrice} Ask {quote.iexAskPrice} Vol {quote.avgTotalVolume}");
        }
    }
}
