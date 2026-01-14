using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Get(){
            return Ok($"API is working. Current Time is {DateTime.Now.ToString("dd-MMM-yyyy HH:MM:ss")}");
        }
    }
}
