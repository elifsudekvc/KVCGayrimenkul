using AutoMapper;
using KVCGayrimenkul.DtoLayer.AboutDto;
using KVCGayrimenkul.EntityLayer.Entities;

namespace KVCGayrimenkulApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
