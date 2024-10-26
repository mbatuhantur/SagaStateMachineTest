using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace LoanAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public LoanController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("check-history/{customerId}")]
        public async Task<IActionResult> CheckLoanHistory(int customerId)
        {
            bool hasGoodHistory = true; // Örneğin: Kredi geçmişi kontrolü burada yapılabilir

            var statusUpdate = new { ApplicationId = customerId, NewStatus = hasGoodHistory ? "Onaylandı" : "Reddedildi" };
            var content = new StringContent(JsonConvert.SerializeObject(statusUpdate), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("http://localhost:5000/api/customer/update-status", content);

            return Ok("Kredi geçmişi kontrol edildi ve Customer API'ye gönderildi.");
        }
    }
}
