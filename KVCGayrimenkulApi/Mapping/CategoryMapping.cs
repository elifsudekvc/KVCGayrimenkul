using AutoMapper;
using KVCGayrimenkul.DtoLayer.AdvertisementTypeDto;
using KVCGayrimenkul.DtoLayer.CategoryDto;
using KVCGayrimenkul.EntityLayer.Entities;

namespace KVCGayrimenkulApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
