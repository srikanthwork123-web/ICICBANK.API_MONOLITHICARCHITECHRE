using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.CustomerService
{
    [Route("api/[controller]")]
    [ApiController]
    public class WillWritingController : ControllerBase
    {
        [HttpGet]
      //  [Route("WillWritingGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
