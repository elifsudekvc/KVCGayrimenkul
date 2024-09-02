using KVCGayrimenkulWebUI.Dtos.AdvertisementDtos;
using KVCGayrimenkulWebUI.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace KVCGayrimenkulWebUI.Controllers
{
	public class AdvertisementController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AdvertisementController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7147/api/Advertisement/AdvertisementWithCategory");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultAdvertisementDto>>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> CreateAdvertisement()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7147/api/Category");
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
			List<SelectListItem> values2=(from x in values
										  select new SelectListItem
										  {
											  Text=x.CategoryName,
											  Value=x.CategoryID.ToString()
										  }).ToList();
			ViewBag.v=values2;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateAdvertisement(CreateAdvertisementDto createAdvertisementDto)
		{
			createAdvertisementDto.AdvertisementStatus = true;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createAdvertisementDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7147/api/Advertisement", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		public async Task<IActionResult> DeleteAdvertisement(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7147/api/Advertisement/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateAdvertisement(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7147/api/Advertisement/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateAdvertisementDto>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateAdvertisement(UpdateAdvertisementDto updateAdvertisementDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateAdvertisementDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7147/api/Advertisement/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
