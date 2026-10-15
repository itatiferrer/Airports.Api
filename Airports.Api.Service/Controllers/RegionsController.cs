using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airports.Api.Service.Infrastructure.Data;

namespace Airports.Api.Service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly Issco2026AirportsDbContext _context;

        public RegionsController(Issco2026AirportsDbContext context)
        {
            _context = context;
        }

        // GET: api/v1/Regions
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetRegions()
        {
            var regions = _context.Regions
                .AsNoTracking()
                .ToList();

            return Ok(regions);
        }

        // GET: api/v1/Regions/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetRegion(int id)
        {
            var region = _context.Regions
                .AsNoTracking()
                .FirstOrDefault(r => r.Id == id);

            if (region == null)
                return NotFound();

            return Ok(region);
        }

        // POST: api/v1/Regions
        [HttpPost]
        public IActionResult CreateRegion()
        {
            return Ok();
        }
    }
}