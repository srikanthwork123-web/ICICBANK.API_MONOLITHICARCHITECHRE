using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.Payments_Transfer
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundTransferController : ControllerBase
    {
        [HttpGet]
      //  [Route("FundTransferGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
