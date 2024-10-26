using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Commands
{
    public class CheckCreditScoreCommand : CorrelatedBy<Guid>
    {
        public int AcountNumber { get; set; }
        public decimal Amount { get; set; }
        public Guid CorrelationId { get; }
        public CheckCreditScoreCommand(Guid correlationId)
        {
            CorrelationId = correlationId;

        }
    }
}
