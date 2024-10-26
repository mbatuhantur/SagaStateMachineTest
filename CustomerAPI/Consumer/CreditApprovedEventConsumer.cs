using MassTransit;
using Messaging.Events;

namespace CustomerAPI.Consumer
{
    public class CreditApprovedEventConsumer : IConsumer<CreditApprovedEvent>
    {
        private readonly ILogger<CreditApprovedEventConsumer> logger;
        public CreditApprovedEventConsumer(ILogger<CreditApprovedEventConsumer> logger)
        {
            this.logger = logger;
        }

        public Task Consume(ConsumeContext<CreditApprovedEvent> context)
        {
            this.logger.LogInformation("creditApprove");
            return Task.CompletedTask;
        }
    }
}
