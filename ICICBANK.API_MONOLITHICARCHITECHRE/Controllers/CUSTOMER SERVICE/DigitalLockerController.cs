using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.CustomerService
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigitalLockerController : ControllerBase
    {
        [HttpGet]
       // [Route("DigitalLockerGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
