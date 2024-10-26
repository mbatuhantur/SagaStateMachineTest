using MassTransit;
using Messaging.Events;

namespace CustomerAPI.Consumer
{
    public class CreditNotApprovedEventConsumer : IConsumer<CreditNotApprovedEvent>
    {
        private readonly ILogger<CreditNotApprovedEventConsumer> logger;
        public CreditNotApprovedEventConsumer(ILogger<CreditNotApprovedEventConsumer> logger)
        {
            this.logger = logger;
        }

        public Task Consume(ConsumeContext<CreditNotApprovedEvent> context)
        {
            this.logger.LogInformation("creditNotApprove");
            return Task.CompletedTask;
        }
    }
}
