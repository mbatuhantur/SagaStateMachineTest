using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Commands
{
    public class LoanRequestCommand
    {
        public int AcountNumber { get; set; }
        public decimal Amount { get; set; }

    }
}
