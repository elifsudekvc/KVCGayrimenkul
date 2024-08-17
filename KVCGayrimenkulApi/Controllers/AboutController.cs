using AutoMapper;
using KVCGayrimenkul.BusinessLayer.Abstract;
using KVCGayrimenkul.DtoLayer.AboutDto;
using KVCGayrimenkul.DtoLayer.CategoryDto;
using KVCGayrimenkul.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            _aboutService.TAdd(new About()
            {
                Description = createAboutDto.Description,
            });
            return Ok("Kategori eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Kategori silindi.");
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            _aboutService.TUpdate(new About()
            {
                Description= updateAboutDto.Description,
                AboutID = updateAboutDto.AboutID,
            });
            return Ok("Kategori güncellendi.");
        }
    }
}
