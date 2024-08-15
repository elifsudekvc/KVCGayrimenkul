using AutoMapper;
using KVCGayrimenkul.DtoLayer.AboutDto;
using KVCGayrimenkul.DtoLayer.AdvertisementTypeDto;
using KVCGayrimenkul.EntityLayer.Entities;

namespace KVCGayrimenkulApi.Mapping
{
    public class AdvertisementTypeMapping:Profile
    {
        public AdvertisementTypeMapping()
        {
            CreateMap<AdvertisementType, ResultAdvertisementTypeDto>().ReverseMap();
            CreateMap<AdvertisementType, GetAdvertisementTypeDto>().ReverseMap();
            CreateMap<AdvertisementType, CreateAdvertisementTypeDto>().ReverseMap();
            CreateMap<AdvertisementType, UpdateAdvertisementTypeDto>().ReverseMap();
        }
    }
}
