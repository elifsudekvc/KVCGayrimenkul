using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using KVCGayrimenkulWebUI.Dtos.AdvertisementDtos;

namespace KVCGayrimenkulWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSatisfactionComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultSatisfactionComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7147/api/Advertisement");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var advertisements = JsonConvert.DeserializeObject<List<ResultAdvertisementDto>>(jsonData);
                var adCount = advertisements.Count;
                ViewBag.AdCount = adCount;
            }
            else
            {
                ViewBag.AdCount = 0; // Hata durumunda 0 dönebiliriz
            }
            return View();
        }
    }
}
