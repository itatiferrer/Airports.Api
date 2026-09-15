using Microsoft.AspNetCore.Mvc;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RoutesController : ControllerBase
    {
        // GET: /api/v1/routes
        [HttpGet]
        public IActionResult GetRoutes()
        {
            return Ok();
        }

        // POST: /api/v1/routes
        [HttpPost]
        public IActionResult CreateRoute()
        {
            return Ok();
        }
    }
}
