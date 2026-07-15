using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.Payments_Transfer
{
    [Route("api/[controller]")]
    [ApiController]
    public class InwardRemittanceController : ControllerBase
    {
        [HttpGet]
      //  [Route("InwardRemittanceGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
