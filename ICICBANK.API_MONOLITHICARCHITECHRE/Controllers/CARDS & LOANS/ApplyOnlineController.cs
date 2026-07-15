using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.Cards_Loans
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplyOnlineController : ControllerBase
    {
        [HttpGet]
       // [Route("ApplyOnlineGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
