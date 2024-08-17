using AutoMapper;
using KVCGayrimenkul.BusinessLayer.Abstract;
using KVCGayrimenkul.DtoLayer.AboutDto;
using KVCGayrimenkul.DtoLayer.MessageDto;
using KVCGayrimenkul.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var value = _mapper.Map<List<ResultMessageDto>>(_messageService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            _messageService.TAdd(new Message()
            {
                Mail = createMessageDto.Mail,
                Name = createMessageDto.Name,
                PersonMessage = createMessageDto.PersonMessage,
                Phone = createMessageDto.Phone,
                SurName = createMessageDto.SurName
            });
            return Ok("Kategori eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            _messageService.TDelete(value);
            return Ok("Kategori silindi.");
        }
        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            _messageService.TUpdate(new Message()
            {
                MessageID = updateMessageDto.MessageID,
                Name = updateMessageDto.Name,
                PersonMessage = updateMessageDto.PersonMessage,
                Phone = updateMessageDto.Phone,
                SurName= updateMessageDto.SurName,
                Mail = updateMessageDto.Mail
            });
            return Ok("Kategori güncellendi.");
        }
    }
}
