using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Events
{
    public class CreditNotApprovedEvent : CorrelatedBy<Guid>
    {
        public int AcountNumber { get; set; }
        public string Message { get; set; }
        public Guid CorrelationId { get; }
        public CreditNotApprovedEvent(Guid correlationId)
        {
            CorrelationId = correlationId;

        }
    }
}
