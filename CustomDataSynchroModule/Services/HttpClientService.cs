using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CustomDataSynchroModule.Interfaces;

namespace CustomDataSynchroModule.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _client;
        public HttpClientService(HttpClient client)
        {
            _client = client;
        }
        public bool Send(HttpRequestMessage request)
        {
            var result = _client.SendAsync(request).Result;
            return result.IsSuccessStatusCode;
            
        }
    }
}
