using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airports.Api.DTOs.DTOsEntrada;
using Airports.Api.DTOs.DTOsSalida;
using Airports.Api.Service.Infrastructure.Data;

namespace Airports.Api.Service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AircraftsController : ControllerBase
    {
        private readonly Issco2026AirportsDbContext _context;

        public AircraftsController(Issco2026AirportsDbContext context)
        {
            _context = context;
        }

        // GET: /api/v1/aircrafts
        [HttpGet]
        public async Task<ActionResult<List<AircraftDto>>> GetAircrafts(
            [FromQuery] string? iataCode,
            [FromQuery] string? search)
        {
            var query = _context.Aircrafts
                .AsNoTracking()
                .AsQueryable();

            // Filtrar por código IATA.
            if (!string.IsNullOrWhiteSpace(iataCode))
            {
                query = query.Where(a => a.Iatacode == iataCode);
            }

            // Buscar por nombre de aeronave.
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(a => a.Name.Contains(search));
            }

            var result = await query
                .Select(a => new AircraftDto
                {
                    Id = a.Id,
                    IataCode = a.Iatacode,
                    Name = a.Name
                })
                .ToListAsync();

            return Ok(result);
        }
        // POST: /api/v1/aircrafts
        [HttpPost]
        public IActionResult CreateAircraft(CreateAircraftDto dto)
        {
            return Ok(dto);
        }
    }
}
