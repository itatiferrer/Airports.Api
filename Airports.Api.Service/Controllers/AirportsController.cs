using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airports.Api.DTOs.DTOsEntrada;    
using Airports.Api.DTOs.DTOsSalida;
using Airports.Api.Service.Infrastructure.Data;
using System.Linq;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AirportsController : ControllerBase
    {
        private readonly Issco2026AirportsDbContext _context;
        public AirportsController(Issco2026AirportsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAirports([FromQuery] GetAirportsParameters parameters)
        {
            var query = _context.Airports
                .AsNoTracking()
                .Include(a => a.Country)
                .Include(a => a.Region)
                .AsQueryable();

            // Agrego los filtros opcionales y acumulativos
            if (parameters.Name != null)
                query = query.Where(a => a.Name.Contains(parameters.Name));

            if (parameters.City != null)
                query = query.Where(a => a.City != null &&
                    a.City.StartsWith(parameters.City));

            if (parameters.CountryId != null)
                query = query.Where(a => a.CountryId == parameters.CountryId);

            if (parameters.IataCode != null)
                query = query.Where(a => a.Iatacode == parameters.IataCode);

            if (parameters.RegionId != null)
                query = query.Where(a => a.RegionId == parameters.RegionId);

            var aeropuertos = query.ToList();

            return Ok(aeropuertos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAirport(int id)
        {
            var airport = _context.Airports
                .Include(a => a.Country)
                .Include(a => a.Region)
                .FirstOrDefault(a => a.Id == id);

            if (airport == null)
                return NotFound();

            return Ok(airport);
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