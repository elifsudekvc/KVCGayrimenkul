using AutoMapper;
using KVCGayrimenkul.DtoLayer.ContactDto;
using KVCGayrimenkul.DtoLayer.MessageDto;
using KVCGayrimenkul.EntityLayer.Entities;

namespace KVCGayrimenkulApi.Mapping
{
    public class MessageMapping:Profile
    {
        public MessageMapping()
        {
            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, GetMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
        }
    }
}
