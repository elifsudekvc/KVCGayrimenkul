using KVCGayrimenkulWebUI.Dtos.AdvertisementDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KVCGayrimenkulWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultAdsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultAdsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7147/api/Advertisement/AdvertisementWithAdvertisementTypeAndCategory");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAdvertisementDto>>(jsonData);
            return View(values);
        }
    
    }
}
