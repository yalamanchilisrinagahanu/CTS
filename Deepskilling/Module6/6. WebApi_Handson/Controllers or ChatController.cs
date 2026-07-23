using KafkaChatApp.Models;
using KafkaChatApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace KafkaChatApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly KafkaProducer _producer;

        public ChatController(KafkaProducer producer)
        {
            _producer = producer;
        }

        [HttpPost]
        public async Task<IActionResult> Send(ChatMessage message)
        {
            await _producer.SendMessage(message);

            return Ok("Message Sent Successfully");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Kafka Chat API Running");
        }
    }
}
