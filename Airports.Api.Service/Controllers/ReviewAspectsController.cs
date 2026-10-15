using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airports.Api.Service.Infrastructure.Data;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ReviewAspectsController : ControllerBase
    {
        private readonly Issco2026AirportsDbContext _context;

        public ReviewAspectsController(Issco2026AirportsDbContext context)
        {
            _context = context;
        }

        // GET: api/v1/ReviewAspects
        [HttpGet]
        public async Task<IActionResult> GetReviewAspects()
        {
            var aspects = await _context.ReviewAspects
                .AsNoTracking()
                .ToListAsync();

            return Ok(aspects);
        }

        // GET: api/v1/ReviewAspects/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReviewAspect(int id)
        {
            var aspect = await _context.ReviewAspects
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);

            if (aspect == null)
            {
                return NotFound();
            }

            return Ok(aspect);
        }
    }
}