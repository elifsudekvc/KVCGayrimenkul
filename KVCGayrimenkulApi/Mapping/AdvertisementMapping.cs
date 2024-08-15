using AutoMapper;
using KVCGayrimenkul.DtoLayer.AboutDto;
using KVCGayrimenkul.DtoLayer.AdvertisementDto;
using KVCGayrimenkul.EntityLayer.Entities;

namespace KVCGayrimenkulApi.Mapping
{
    public class AdvertisementMapping:Profile
    {
        public AdvertisementMapping()
        {
            CreateMap<Advertisement, ResultAdvertisementDto>().ReverseMap();
            CreateMap<Advertisement, GetAdvertisementDto>().ReverseMap();
            CreateMap<Advertisement, CreateAdvertisementDto>().ReverseMap();
            CreateMap<Advertisement, UpdateAdvertisementDto>().ReverseMap();
        }
    }
}
