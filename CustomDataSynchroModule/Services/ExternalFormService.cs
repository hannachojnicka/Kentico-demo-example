using CustomDataSynchroModule.Helpers;
using CustomDataSynchroModule.Interfaces;
using CustomDataSynchroModule.Models.Dto;
using System.Net.Http;


namespace CustomDataSynchroModule.Services
{
    public class ExternalFormService : IExternalFormService
    {
        private readonly IHttpClientService _httpClientService;

        public ExternalFormService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public bool SendFormToExternalServer(CoffeSampleListDto formDataItem, string urlAddressValue)
        {
            var content = formDataItem.ToKeyValue();

            var request = new HttpRequestMessage(HttpMethod.Post, urlAddressValue)
            {
                Content = new FormUrlEncodedContent(content)
            };

            return _httpClientService.Send(request);
        }

    }
}
