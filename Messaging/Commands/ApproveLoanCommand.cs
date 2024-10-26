using MassTransit;

namespace Messaging.Commands
{

    public class ApproveLoanCommand : CorrelatedBy<Guid>
    {
        public int AcountNumber { get; set; }
        public decimal Amount { get; set; }
        public Guid CorrelationId { get; }
        public ApproveLoanCommand(Guid correlationId)
        {
            CorrelationId = correlationId;

        }
    }
}
