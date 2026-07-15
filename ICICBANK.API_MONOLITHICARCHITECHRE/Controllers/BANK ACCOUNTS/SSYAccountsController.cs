using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API_MONOLITHICARCHITECHRE.Controllers.BANK_ACCOUNTS
{
    [Route("api/[controller]")]
    [ApiController]
    public class SSYAccountsController : ControllerBase
    {
        [HttpGet]
       // [Route("SSYAccountsGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
