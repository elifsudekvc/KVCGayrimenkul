using KVCGayrimenkulWebUI.Dtos.AdvertisementDtos;
using KVCGayrimenkulWebUI.Dtos.AdvertisementTypeDtos;
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
			var responseMessage = await client.GetAsync("https://localhost:7147/api/Advertisement/AdvertisementWithAdvertisementTypeAndCategory");
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

			// Kategoriler için API çağrısı
			var categoryResponse = await client.GetAsync("https://localhost:7147/api/Category");
			var categoryJsonData = await categoryResponse.Content.ReadAsStringAsync();
			var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoryJsonData);
			List<SelectListItem> categoryItems = categories.Select(x => new SelectListItem
			{
				Text = x.CategoryName,
				Value = x.CategoryID.ToString()
			}).ToList();
			ViewBag.CategoryList = categoryItems;

			// İlan Tipleri için API çağrısı
			var advertisementTypeResponse = await client.GetAsync("https://localhost:7147/api/AdvertisementType");
			var advertisementTypeJsonData = await advertisementTypeResponse.Content.ReadAsStringAsync();
			var advertisementTypes = JsonConvert.DeserializeObject<List<ResultAdvertisementTypeDto>>(advertisementTypeJsonData);
			List<SelectListItem> advertisementTypeItems = advertisementTypes.Select(x => new SelectListItem
			{
				Text = x.AdvertisementTypeName,
				Value = x.AdvertisementTypeID.ToString()
			}).ToList();
			ViewBag.AdvertisementTypeList = advertisementTypeItems;

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

			// Kategoriler için API çağrısı
			var categoryResponse = await client.GetAsync("https://localhost:7147/api/Category");
			var categoryJsonData = await categoryResponse.Content.ReadAsStringAsync();
			var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoryJsonData);
			List<SelectListItem> categoryItems = categories.Select(x => new SelectListItem
			{
				Text = x.CategoryName,
				Value = x.CategoryID.ToString()
			}).ToList();
			ViewBag.CategoryList = categoryItems;

			// İlan Tipleri için API çağrısı
			var advertisementTypeResponse = await client.GetAsync("https://localhost:7147/api/AdvertisementType");
			var advertisementTypeJsonData = await advertisementTypeResponse.Content.ReadAsStringAsync();
			var advertisementTypes = JsonConvert.DeserializeObject<List<ResultAdvertisementTypeDto>>(advertisementTypeJsonData);
			List<SelectListItem> advertisementTypeItems = advertisementTypes.Select(x => new SelectListItem
			{
				Text = x.AdvertisementTypeName,
				Value = x.AdvertisementTypeID.ToString()
			}).ToList();
			ViewBag.AdvertisementTypeList = advertisementTypeItems;

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
			updateAdvertisementDto.AdvertisementStatus = true;
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
