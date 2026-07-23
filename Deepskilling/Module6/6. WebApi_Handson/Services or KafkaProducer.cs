using Confluent.Kafka;
using System.Text.Json;
using KafkaChatApp.Models;

namespace KafkaChatApp.Services
{
    public class KafkaProducer
    {
        private readonly IConfiguration _configuration;

        public KafkaProducer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendMessage(ChatMessage message)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = _configuration["Kafka:BootstrapServers"]
            };

            using var producer =
                new ProducerBuilder<Null, string>(config).Build();

            var json = JsonSerializer.Serialize(message);

            await producer.ProduceAsync(
                _configuration["Kafka:Topic"],
                new Message<Null, string>
                {
                    Value = json
                });
        }
    }
}
