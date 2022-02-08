﻿using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace XFactoryMT
{
    public class Message
    {
        public string Text { get; set; }
    }
    
    public class MessageConsumer : IConsumer<Message>
    {
        private readonly ILogger<MessageConsumer> _logger;

        public MessageConsumer(ILogger<MessageConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Message> context)
        {
            _logger.LogInformation("Recebendo texto: {Text}", context.Message.Text);
            
            return Task.CompletedTask;
        }
    }
}