using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.Overview
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountSummaryController : ControllerBase
    {
        [HttpGet]
        //[Route("AccountSummaryGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
