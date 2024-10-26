using MassTransit;
using Messaging.Commands;
using Messaging.Events;

namespace CreditAPI.Consumer
{
    public class CheckCreditCommandConsumer : IConsumer<CheckCreditScoreCommand>
    {
        readonly ISendEndpointProvider _sendEndpointProvider;
        public CheckCreditCommandConsumer(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }
        public async Task Consume(ConsumeContext<CheckCreditScoreCommand> context)
        {
            ISendEndpoint sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri($"queue:{Microsoft.AspNetCore.Components.Endpoints.LoanStateMachine}"));

            if (context.Message.Amount > 1000000)
            {
                await sendEndpoint.Send(new CreditNotApprovedEvent(context.Message.CorrelationId) { AcountNumber = context.Message.AcountNumber, Message = "İstenilen kredi miktari çok yüksek" });
            }
            else
            {
                await sendEndpoint.Send(new CreditApprovedEvent(context.Message.CorrelationId) { AcountNumber = context.Message.AcountNumber });
            }
        }
    }
}
