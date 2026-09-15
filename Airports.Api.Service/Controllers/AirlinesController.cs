using Microsoft.AspNetCore.Mvc;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AirlinesController : ControllerBase
    {
        // GET: /api/v1/airlines
        [HttpGet]
        public IActionResult GetAirlines()
        {
            return Ok();
        }

        // GET: /api/v1/airlines/{id}
        [HttpGet("{id}")]
        public IActionResult GetAirline(int id)
        {
            return Ok();
        }

        // POST: /api/v1/airlines
        [HttpPost]
        public IActionResult CreateAirline()
        {
            return Ok();
        }

        // GET: /api/v1/airlines/{id}/countries
        [HttpGet("{id}/countries")]
        public IActionResult GetAirlineCountries(int id)
        {
            return Ok();
        }

        // POST: /api/v1/airlines/{id}/countries
        [HttpPost("{id}/countries")]
        public IActionResult AddAirlineCountry(int id)
        {
            return Ok();
        }

        // DELETE: /api/v1/airlines/{airlineId}/countries/{countryId}
        [HttpDelete("{airlineId}/countries/{countryId}")]
        public IActionResult DeleteAirlineCountry(int airlineId, int countryId)
        {
            return Ok();
        }
    }
}
