using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Events
{
    public class LoanFaildEvent : CorrelatedBy<Guid>
    {
        public int AcountNumber { get; set; }
        public string Message { get; set; }
        public Guid CorrelationId { get; }
        public LoanFaildEvent(Guid correlationId)
        {
            CorrelationId = correlationId;

        }
    }
}
