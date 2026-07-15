using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.Investments_Insurance
{
    [Route("api/[controller]")]
    [ApiController]
    public class PPFAccountsController : ControllerBase
    {
        [HttpGet]
     //   [Route("PPFAccountsGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
