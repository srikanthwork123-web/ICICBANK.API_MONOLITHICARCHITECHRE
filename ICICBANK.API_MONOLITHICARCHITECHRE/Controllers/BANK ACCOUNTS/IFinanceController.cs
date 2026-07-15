using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API_MONOLITHICARCHITECHRE.Controllers.BANK_ACCOUNTS
{
    [Route("api/[controller]")]
    [ApiController]
    public class IFinanceController : ControllerBase
    {
        [HttpGet]
       // [Route("IFinanceGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
