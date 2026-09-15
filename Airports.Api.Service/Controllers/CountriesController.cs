using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airports.Api.Service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        
        // GET: /api/v1/countries
        [HttpGet]
        public IActionResult GetCountries()
        {
            return Ok();
        }

        // GET: /api/v1/countries/{id}
        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            return Ok();
        }

        // POST: /api/v1/countries
        [HttpPost]
        public IActionResult CreateCountry()
        {
            return Ok();
        }

        // PUT: /api/v1/countries/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCountry(int id)
        {
            return Ok();
        }

        // GET: /api/v1/countries/{countryId}/regions
        [HttpGet("{countryId}/regions")]
        public IActionResult GetCountryRegions(int countryId)
        {
            return Ok();
        }
    }
}
