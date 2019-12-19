using System;
using System.Threading;
using System.Threading.Tasks;

namespace IEXCloudClient.Common
{
    public sealed class RequestManager
    {
        private static readonly Lazy<RequestManager> _instance = new Lazy<RequestManager>(() => new RequestManager());
        
        public static RequestManager I
        {
            get { return _instance.Value; }
        }

        private readonly double MS_PER_REQUEST = 10;
        private readonly object _lock = new object();
        private DateTime _lastRequest;

        private RequestManager()
        { }

        public async Task ThrottleAsync()
        {
            await Task.Run(() => Throttle());
        }

        public void Throttle()
        {
            lock (_lock)
            {
                var msecSinceLast = (DateTime.Now - _lastRequest).TotalMilliseconds;

                if (msecSinceLast > MS_PER_REQUEST)
                    Thread.Sleep((int)(MS_PER_REQUEST - msecSinceLast));

                _lastRequest = DateTime.Now;
            }

        }
    }
}
