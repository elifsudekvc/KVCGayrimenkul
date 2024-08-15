using AutoMapper;
using KVCGayrimenkul.DtoLayer.CategoryDto;
using KVCGayrimenkul.DtoLayer.ContactDto;
using KVCGayrimenkul.EntityLayer.Entities;

namespace KVCGayrimenkulApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
        }
    }
}
