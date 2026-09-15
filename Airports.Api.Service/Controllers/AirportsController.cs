using Microsoft.AspNetCore.Mvc;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AirportsController : ControllerBase
    {
        // GET: /api/v1/airports
        [HttpGet]
        public IActionResult GetAirports()
        {
            return Ok();
        }

        // GET: /api/v1/airports/{id}
        [HttpGet("{id}")]
        public IActionResult GetAirport(int id)
        {
            return Ok();
        }

        // POST: /api/v1/airports
        [HttpPost]
        public IActionResult CreateAirport()
        {
            return Ok();
        }

        // PUT: /api/v1/airports/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateAirport(int id)
        {
            return Ok();
        }

        // PATCH: /api/v1/airports/{id}/runway-status
        [HttpPatch("{id}/runway-status")]
        public IActionResult UpdateRunwayStatus(int id)
        {
            return Ok();
        }
    }
}