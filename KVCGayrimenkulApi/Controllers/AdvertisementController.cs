using AutoMapper;
using KVCGayrimenkul.BusinessLayer.Abstract;
using KVCGayrimenkul.DataAccessLayer.Concrete;
using KVCGayrimenkul.DtoLayer.AdvertisementDto;
using KVCGayrimenkul.DtoLayer.CategoryDto;
using KVCGayrimenkul.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KVCGayrimenkulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private readonly IAdvertisementService _advertisementService;
        private readonly IMapper _mapper;

        public AdvertisementController(IAdvertisementService advertisementService, IMapper mapper)
        {
            _advertisementService = advertisementService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AdvertisementList()
        {
            var value = _mapper.Map<List<ResultAdvertisementDto>>(_advertisementService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("AdvertisementWithCategory")]
        public IActionResult AdvertisementWithCategory()
        {
            var context = new KVCGayrimenkulContext();
            var values = context.Advertisements.Include(x => x.Category).Select(y => new ResultAdvertisementWithCategory
            {
                AdvertisementID = y.AdvertisementID,
                AdvertisementName = y.AdvertisementName,
                AdvertisementStatus = y.AdvertisementStatus,
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                SquareMeters = y.SquareMeters,
                CategoryName = y.Category.CategoryName
            }).ToList();
            return Ok(values.ToList());
        }


		[HttpGet("AdvertisementWithAdvertisementType")]
		public IActionResult AdvertisementWithAdvertisementType()
		{
			var context = new KVCGayrimenkulContext();
			var values = context.Advertisements.Include(x => x.AdvertisementType).Select(y => new ResultAdvertisementWithAdvertisementType
			{
				AdvertisementID = y.AdvertisementID,
				AdvertisementName = y.AdvertisementName,
				AdvertisementStatus = y.AdvertisementStatus,
				Description = y.Description,
				ImageUrl = y.ImageUrl,
				Price = y.Price,
				SquareMeters = y.SquareMeters,
				AdvertisementTypeName = y.AdvertisementType.AdvertisementTypeName,
			}).ToList();
			return Ok(values.ToList());
		}

		[HttpGet("AdvertisementWithAdvertisementTypeAndCategory")]
		public IActionResult AdvertisementWithAdvertisementTypeAndCategory()
		{
			var context = new KVCGayrimenkulContext();
			var values = context.Advertisements.Include(x => x.AdvertisementType).Select(y => new ResultAdvertisementWithAdvertisementTypeAndCategory
			{
				AdvertisementID = y.AdvertisementID,
				AdvertisementName = y.AdvertisementName,
				AdvertisementStatus = y.AdvertisementStatus,
				Description = y.Description,
				ImageUrl = y.ImageUrl,
				Price = y.Price,
				SquareMeters = y.SquareMeters,
				AdvertisementTypeName = y.AdvertisementType.AdvertisementTypeName,
                CategoryName = y.Category.CategoryName
			}).ToList();
			return Ok(values.ToList());
		}

		[HttpPost]
        public IActionResult CreateAdvertisement(CreateAdvertisementDto createAdvertisementDto)
        {
            _advertisementService.TAdd(new Advertisement()
            {
                AdvertisementName = createAdvertisementDto.AdvertisementName,
                AdvertisementStatus = createAdvertisementDto.AdvertisementStatus,
                Description = createAdvertisementDto.Description,
                ImageUrl = createAdvertisementDto.ImageUrl,
                Price = createAdvertisementDto.Price,
                SquareMeters = createAdvertisementDto.SquareMeters,
                CategoryID = createAdvertisementDto.CategoryID,
                AdvertisementTypeID = createAdvertisementDto.AdvertisementTypeID
			});
            return Ok("İlan eklendi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAdvertisement(int id)
        {
            var value = _advertisementService.TGetByID(id);
            _advertisementService.TDelete(value);
            return Ok("İlan silindi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetAdvertisement(int id)
        {
            var value = _advertisementService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateAdvertisement(UpdateAdvertisementDto updateAdvertisementDto)
        {
            _advertisementService.TUpdate(new Advertisement()
            {
                AdvertisementID = updateAdvertisementDto.AdvertisementID,
                SquareMeters = updateAdvertisementDto.SquareMeters,
                Price = updateAdvertisementDto.Price,
                ImageUrl=updateAdvertisementDto.ImageUrl,
                Description = updateAdvertisementDto.Description,
                AdvertisementStatus = updateAdvertisementDto.AdvertisementStatus,
                AdvertisementName = updateAdvertisementDto.AdvertisementName,
                CategoryID = updateAdvertisementDto.CategoryID,
                AdvertisementTypeID = updateAdvertisementDto.AdvertisementTypeID
            });
            return Ok("İlan güncellendi.");
        }
    }
}
