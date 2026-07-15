using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.Overview
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyViewController : ControllerBase
    {
        [HttpGet]
    //    [Route("MyViewGetData")]
        public async Task<IActionResult> Get()
        {
            // Implement logic to retrieve accounts
            return Ok(new { message = "SampleTesting" });
        }
    }
}
