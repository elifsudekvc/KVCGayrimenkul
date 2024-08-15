using AutoMapper;
using KVCGayrimenkul.DtoLayer.MessageDto;
using KVCGayrimenkul.DtoLayer.SocialMediaDto;
using KVCGayrimenkul.EntityLayer.Entities;

namespace KVCGayrimenkulApi.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        }
    }
}
