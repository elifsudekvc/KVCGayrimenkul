﻿using AutoMapper;
using KVCGayrimenkul.BusinessLayer.Abstract;
using KVCGayrimenkul.DtoLayer.AdvertisementDto;
using KVCGayrimenkul.DtoLayer.CategoryDto;
using KVCGayrimenkul.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                SquareMeters = createAdvertisementDto.SquareMeters
            });
            return Ok("İlan eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteAdvertisement(int id)
        {
            var value = _advertisementService.TGetByID(id);
            _advertisementService.TDelete(value);
            return Ok("İlan silindi.");
        }
        [HttpGet("GetAdvertisement")]
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
                AdvertisementName = updateAdvertisementDto.AdvertisementName
            });
            return Ok("İlan güncellendi.");
        }
    }
}
