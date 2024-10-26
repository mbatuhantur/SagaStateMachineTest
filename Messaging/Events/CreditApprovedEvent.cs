using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Events
{
    public class CreditApprovedEvent: CorrelatedBy<Guid>
    {
        public int AcountNumber { get; set; }
        public Guid CorrelationId { get; }
        public CreditApprovedEvent(Guid correlationId)
        {
            CorrelationId = correlationId;

        }
    }

}
