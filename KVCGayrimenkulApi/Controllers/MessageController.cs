using KVCGayrimenkul.BusinessLayer.Abstract;
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

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            Message message = new Message()
            {
                Mail = createMessageDto.Mail,
                Name = createMessageDto.Name,
                PersonMessage = createMessageDto.PersonMessage,
                Phone = createMessageDto.Phone,
                SurName = createMessageDto.SurName,
            };
            _messageService.TAdd(message);
            return Ok("Mesajınız iletildi");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            _messageService.TDelete(value);
            return Ok("Mesaj Silindi");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            Message message = new Message()
            {
                Mail = updateMessageDto.Mail,
                Name = updateMessageDto.Name,
                PersonMessage = updateMessageDto.PersonMessage,
                Phone = updateMessageDto.Phone,
                MessageID = updateMessageDto.MessageID,
                SurName = updateMessageDto.SurName,
            };
            _messageService.TUpdate(message);
            return Ok("Mesaj güncellendi.");
        }
        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            return Ok(value);
        }
    }
}
