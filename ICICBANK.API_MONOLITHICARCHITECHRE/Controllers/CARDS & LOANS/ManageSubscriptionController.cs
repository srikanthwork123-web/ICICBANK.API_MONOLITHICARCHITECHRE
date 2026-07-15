using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.Cards_Loans
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageSubscriptionController : ControllerBase
    {
        [HttpGet]
       // [Route("ManageSubscriptionGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
