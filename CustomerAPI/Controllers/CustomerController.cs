using MassTransit;
using Messaging;
using Messaging.Commands;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public CustomerController(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }

        [HttpPost]
        public async Task<IActionResult> ApplyForCredit([FromBody] CreditApplicationRequest request)
        {
            
            ISendEndpoint sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri($"queue:{Queues.LoanStateMachineConnection}"));
            LoanRequestCommand command = new LoanRequestCommand
            {
             AcountNumber = request.AcountNumber,
             Amount = request.Amount,
            };

            await sendEndpoint.Send(command);
            return Ok();
           
        }

        [HttpPut("update-status")]
        public IActionResult UpdateCreditStatus([FromBody] CreditStatusUpdateRequest statusUpdate)
        {
            return Ok("Başvuru durumu güncellendi: " + statusUpdate.NewStatus);
        }
    }

    public class CreditApplicationRequest
    {
        public int AcountNumber { get; set; }
        public decimal Amount { get; set; }
    }

    public class CreditStatusUpdateRequest
    {
        public int ApplicationId { get; set; }
        public string NewStatus { get; set; }
    }
}
