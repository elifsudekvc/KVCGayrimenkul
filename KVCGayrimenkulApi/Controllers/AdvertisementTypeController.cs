using AutoMapper;
using KVCGayrimenkul.BusinessLayer.Abstract;
using KVCGayrimenkul.DtoLayer.AdvertisementDto;
using KVCGayrimenkul.DtoLayer.AdvertisementTypeDto;
using KVCGayrimenkul.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementTypeController : ControllerBase
    {
        private readonly IAdvertisementTypeService _advertisementTypeService;
        private readonly IMapper _mapper;

        public AdvertisementTypeController(IAdvertisementTypeService advertisementTypeService, IMapper mapper)
        {
            _advertisementTypeService = advertisementTypeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AdvertisementTypeList()
        {
            var value = _mapper.Map<List<ResultAdvertisementTypeDto>>(_advertisementTypeService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateAdvertisementType(CreateAdvertisementTypeDto createAdvertisementTypeDto)
        {
            _advertisementTypeService.TAdd(new AdvertisementType()
            {
                AdvertisementTypeName = createAdvertisementTypeDto.AdvertisementTypeName,
                AdvertisementTypeStatus = createAdvertisementTypeDto.AdvertisementTypeStatus
            });
            return Ok("İlan tipi eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteAdvertisementType(int id)
        {
            var value = _advertisementTypeService.TGetByID(id);
            _advertisementTypeService.TDelete(value);
            return Ok("İlan tipi silindi.");
        }
        [HttpGet("GetAdvertisementType")]
        public IActionResult GetAdvertisementType(int id)
        {
            var value = _advertisementTypeService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateAdvertisementType(UpdateAdvertisementTypeDto updateAdvertisementTypeDto)
        {
            _advertisementTypeService.TUpdate(new AdvertisementType()
            {
                AdvertisementTypeID = updateAdvertisementTypeDto.AdvertisementTypeID,
                AdvertisementTypeName = updateAdvertisementTypeDto.AdvertisementTypeName,
                AdvertisementTypeStatus = updateAdvertisementTypeDto.AdvertisementTypeStatus
            });
            return Ok("İlan tipi güncellendi.");
        }
    }
}
