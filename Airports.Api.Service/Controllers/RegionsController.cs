using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airports.Api.Service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        // POST: /api/v1/regions
        [HttpPost]
        public IActionResult CreateRegion()
        {
            return Ok();
        }
    }
}
