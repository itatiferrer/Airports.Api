using Microsoft.AspNetCore.Mvc;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FlightsController : ControllerBase
    {
        // GET: /api/v1/flights
        [HttpGet]
        public IActionResult GetFlights()
        {
            return Ok();
        }

        // GET: /api/v1/flights/{id}
        [HttpGet("{id}")]
        public IActionResult GetFlight(int id)
        {
            return Ok();
        }

        // POST: /api/v1/flights
        [HttpPost]
        public IActionResult CreateFlight()
        {
            return Ok();
        }
    }
}