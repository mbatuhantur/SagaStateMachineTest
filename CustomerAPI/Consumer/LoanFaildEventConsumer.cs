using MassTransit;
using Messaging.Events;

namespace CustomerAPI.Consumer
{
    public class LoanFaildEventConsumer : IConsumer<LoanFaildEvent>
    {
        private readonly ILogger<LoanFaildEventConsumer> logger;
        public LoanFaildEventConsumer(ILogger<LoanFaildEventConsumer> logger)
        {
            this.logger = logger;
        }

        public Task Consume(ConsumeContext<LoanFaildEvent> context)
        {
            this.logger.LogInformation("loanFailApprove");
            return Task.CompletedTask;
        }
    }
}
