using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Airports.Api.DTOs.DTOsEntrada;

namespace Airports.Api.Service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AircraftsController : ControllerBase
    {
        // GET: /api/v1/aircrafts
        [HttpGet]
        public IActionResult GetAircrafts()
        {
            return Ok();
        }

        // POST: /api/v1/aircrafts
        [HttpPost]
        public IActionResult CreateAircraft(CreateAircraftDto dto)
        {
            return Ok(dto);
        }
    }
}
