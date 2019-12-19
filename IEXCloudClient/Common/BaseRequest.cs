using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IEXCloudClient.Common
{
    internal abstract class BaseRequest<TResponse> : IRequest<TResponse>
    {
        private string endpoint;

        private HttpClient client;

        protected Dictionary<string, string> Parameters { get; private set; }

        public BaseRequest(string baseUrl, string token)
        {
            var baseUri = new Uri(baseUrl);

            client = new HttpClient();
            client.BaseAddress = baseUri;

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Parameters = new Dictionary<string, string>();
            Parameters.Add("token", token);
        }

        protected void SetEndpoint(string ept)
        {
            endpoint = ept;
        }

        protected void SetEndpoint(params string[] args)
        {
            endpoint = string.Join("/", args);
        }

        public async Task<TResponse> SendRequestAsync()
        {
            AddParameters();

            await RequestManager.I.ThrottleAsync();

            var response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
                return await DeserializeResponse(response);
            else
                throw new HttpRequestException(string.Format("HTTP Request Failure: Code {0} Reason {1}",
                    response.StatusCode,
                    response.ReasonPhrase));
        }

        private void AddParameters()
        {
            if (Parameters.Count == 0)
                return;

            var queryString = String.Join("&", Parameters.Select(a => $"{a.Key}={a.Value}"));
            endpoint = string.Format("{0}?{1}", endpoint, queryString);
        }

        private async Task<TResponse> DeserializeResponse(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(content);
        }
    }
}
