using MassTransit;
using Messaging.Events;

namespace CustomerAPI.Consumer
{
    public class LoanApprovedEventConsumer : IConsumer<LoanApprovedEvent>
    {
        private readonly ILogger<LoanApprovedEventConsumer> logger;
        public LoanApprovedEventConsumer(ILogger<LoanApprovedEventConsumer> logger)
        {
            this.logger = logger;
        }

        public Task Consume(ConsumeContext<LoanApprovedEvent> context)
        {
            this.logger.LogInformation("loanApprove");
            return Task.CompletedTask;
        }
    }
}
