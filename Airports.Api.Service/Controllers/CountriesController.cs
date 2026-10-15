using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airports.Api.Service.Infrastructure.Data;

namespace Airports.Api.Service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly Issco2026AirportsDbContext _context;

        public CountriesController(Issco2026AirportsDbContext context)
        {
            _context = context;
        }

        // GET: api/v1/countries
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetCountries()
        {
            var countries = _context.Countries
                .AsNoTracking()
                .ToList();

            return Ok(countries);
        }

        // GET: api/v1/countries/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCountry(int id)
        {
            var country = _context.Countries
                .AsNoTracking()
                .FirstOrDefault(c => c.Id == id);

            if (country == null)
                return NotFound();

            return Ok(country);
        }

        // GET: api/v1/countries/{countryId}/regions
        [HttpGet("{countryId}/regions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCountryRegions(int countryId)
        {
            var countryExists = _context.Countries
                .Any(c => c.Id == countryId);

            if (!countryExists)
                return NotFound();

            var regions = _context.Regions
                .AsNoTracking()
                .Where(r => r.CountryId == countryId)
                .ToList();

            return Ok(regions);
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

      
    }
}
