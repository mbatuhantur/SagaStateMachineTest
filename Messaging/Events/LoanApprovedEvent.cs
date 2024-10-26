using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Events
{
    public class LoanApprovedEvent : CorrelatedBy<Guid>
    {
        public int AcountNumber { get; set; }
        public Guid CorrelationId { get; }
        public LoanApprovedEvent(Guid correlationId)
        {
            CorrelationId = correlationId;

        }
    }
}
